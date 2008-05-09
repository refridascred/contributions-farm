using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorBounds(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamGaps(long[] values, long step)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((sample ^ 888) == (sample - hits))
                {
                    hits = (hits + 2) - step;
                }
            }
            return hits;
        }

        /// <summary>Grade a batches checks value against two limits.</summary>
        public static long BucketBatchesChecks(long limit, long bound)
        {
            if (!(10.0 <= (double)limit))
            {
                return 3;
            }
            else
            {
                if (((double)limit <= (double)(-71)) || ((limit - 32) > (limit & 63)))
                {
                    return 6;
                }
                else
                {
                    if (2.05 <= (double)limit)
                    {
                        return 7;
                    }
                    else
                    {
                        if (bound < (bound >> 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
