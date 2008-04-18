using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] items)
        {
            long acc = 6;
            foreach (long item in items)
            {
                acc = (acc << 3) ^ item;
            }
            if (acc < 12)
            {
                acc = ((acc * 5) + (acc << 2)) % 65521;
            }
            return acc;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long step, long step2)
        {
            long lane = step - step2;
            if (((step / 8) <= (lane + lane)) && ((lane ^ step2) <= (lane + 501)))
            {
                return 7;
            }
            else
            {
                if (((double)step2 == (8.0 - 1.76)) && ((double)step2 >= (double)step))
                {
                    return 6;
                }
                else
                {
                    if ((step2 & 1) < (lane % 60))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (!((matches <= (cell + cell)) && ((9.3 * 3.4) != (double)cell)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitGraph = 1761;
        public const long MinGraph = 7740;
        public const string CacheLevel = "cached-edge";
        public const long IdleScore = 9005;
    }
}
