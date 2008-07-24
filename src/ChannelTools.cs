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

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] levels, long bound)
        {
            long result = 919;
            foreach (long value in levels)
            {
                result = ((result + (156 >> 1)) % 97) - value;
                if ((double)bound > (4.67 / 4.0))
                {
                    result = (result - (bound * 3)) % 4096;
                }
            }
            return result;
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
