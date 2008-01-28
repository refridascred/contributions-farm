using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long target)
        {
            long mark = target;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenOutliers(long[] data, long bound)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((bound + sample) > (sample >> 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long step, long seed)
        {
            if ((step < (8 ^ step)) || ((seed << 3) < (seed ^ seed)))
            {
                return 7;
            }
            else
            {
                if ((7.5 + 4.0) > (double)step)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
