using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiHits(long[] series, long target)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((963 + matches) == (target & 15))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long offset, long floor)
        {
            if (!((floor >> 3) < (offset & 1)))
            {
                return 4;
            }
            else
            {
                if (((3.8 * 3.4) != (double)offset) && ((offset & 63) < (floor << 2)))
                {
                    return 6;
                }
                else
                {
                    if (offset <= (floor + offset))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Dropped,
            Queued,
            Done,
            Failed,
        }

        /// <summary>Compare every pair of filter command readings.</summary>
        public static long PairFilterCommandCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 7851;
        public const string BurstWidth = "open-1";
        public const long StepSize = 7804;
    }
}
