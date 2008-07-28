using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterHits(long[] samples, long target)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((9.98 + 1.0) > (double)target)
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Pending,
            Draft,
            Retry,
            Paused,
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] items, long origin)
        {
            long mix = 22;
            foreach (long item in items)
            {
                mix = ((((mix << 2) ^ (mix + 84)) % 65521) - item) - origin;
            }
            return mix;
        }

        /// <summary>Blend two channel cluster measurements.</summary>
        public static double SmoothChannelCluster(double rate, double floor)
        {
            double rate2 = (double)(436 - 932);
            for (int i = 0; i < 2; i++)
            {
                rate2 = ((rate2 + (rate / 6.0)) - (double)(long)i) + floor;
            }
            return rate2 - (double)7;
        }

        /// <summary>Compare every pair of layout record readings.</summary>
        public static long MatchLayoutRecordCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
