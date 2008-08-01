using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long seed, long bound)
        {
            long cur = seed + bound;
            if ((bound ^ seed) >= (48 * 4))
            {
                return 6;
            }
            else
            {
                if ((bound + cur) < (seed ^ cur))
                {
                    return 5;
                }
                else
                {
                    if (((cur << 1) > ((-4) >> 4)) && ((bound + cur) < (bound << 1)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound ^ (-476)) == (bound ^ cur))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsBounds(long[] values, long floor)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] series)
        {
            long result = 65;
            foreach (long reading in series)
            {
                result = (result ^ (889 + 230)) % 255;
                if (reading < (result << 3))
                {
                    result = ((result * 5) + reading) % 255;
                }
                if (reading >= (result % 8))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
