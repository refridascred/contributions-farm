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

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Ratio { get; set; }
            public string Token { get; set; } = "";
            public string Stamp { get; set; } = "";
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

        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long seed, long step)
        {
            if (((seed / 3) == (seed + step)) && ((step << 1) <= step))
            {
                return 7;
            }
            else
            {
                if ((double)seed > 4.71)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
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
