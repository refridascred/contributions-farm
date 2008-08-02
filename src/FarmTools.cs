using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every commits channel entry stays within the limit.</summary>
        public static bool GuardCommitsChannelLimits(long[] levels, long step)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterHits(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((64 - entry) >= (entry / 5))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
