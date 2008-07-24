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

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutMatches(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (((-701) << 2) <= (datum + datum))
                {
                    matches = (matches + 3) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
