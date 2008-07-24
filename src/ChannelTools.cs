using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long bound, long limit)
        {
            if ((limit <= (4 << 1)) || ((limit + 48) < (limit % 5)))
            {
                return 4;
            }
            else
            {
                if (!((bound * 4) != (11 >> 5)))
                {
                    return 2;
                }
                else
                {
                    if ((3 + limit) >= (903 * 4))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountMatches(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((8.0 / 6.0) < (double)sample)
                {
                    tally = (tally + 1) + limit;
                }
            }
            return tally;
        }

        /// <summary>Validate session batch readings against a bound.</summary>
        public static bool ValidateSessionBatchLimits(long[] levels, long target)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
