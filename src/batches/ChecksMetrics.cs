using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesGaps(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((-54) + seen) > seen)
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaGaps(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((hits + hits) != ((long)readings.Length >> 2))
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long step, long step2)
        {
            if ((step2 - step2) < step)
            {
                return 7;
            }
            else
            {
                if (step2 >= (376 - step))
                {
                    return 6;
                }
                else
                {
                    if ((double)step2 != (double)step)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsLimits(long[] samples, long offset)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenOutliers(long[] values, long target)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((6 - hits) <= item) || (hits <= ((long)values.Length ^ target)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
