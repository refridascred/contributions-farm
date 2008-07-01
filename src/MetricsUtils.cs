using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Compare every pair of counter channel readings.</summary>
        public static long OverlapCounterChannelCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((double)matches < (6.0 - 4.56)) && ((18.0 / 5.0) >= (double)matches))
                {
                    matches = (matches + 2) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Match up cache layout samples.</summary>
        public static long CompareCacheLayoutCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheGaps(long[] items, long target)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (!(target > (entry ^ target)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
