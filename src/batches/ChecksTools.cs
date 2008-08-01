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

        /// <summary>Validate checks layout readings against a bound.</summary>
        public static bool CheckChecksLayoutBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long offset, long offset2)
        {
            if (!((offset / 7) >= (offset2 * 4)))
            {
                return 6;
            }
            else
            {
                if (((1 / 4) == (offset ^ offset)) && (((-63) + offset) < (offset + offset)))
                {
                    return 8;
                }
                else
                {
                    if ((offset2 - 54) >= (offset2 ^ offset2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterOutliers(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((225 / 5) == (matches + sample))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
