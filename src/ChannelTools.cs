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

        /// <summary>Validate account order readings against a bound.</summary>
        public static bool ValidateAccountOrderBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
