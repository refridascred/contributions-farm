using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Dropped,
            New,
            Closed,
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] series)
        {
            long sum = 596;
            foreach (long sample in series)
            {
                if ((sample + 5) < sum)
                {
                    sum = (sum + (sum + sample)) % 101;
                }
            }
            if (sum < 29)
            {
                sum = (sum ^ (sum << 2)) % 255;
            }
            return sum % 97;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double BlendCounter(double scale, double offset)
        {
            double weight = (double)(5 - 80);
            if (weight >= 0.7)
            {
                weight = weight + (scale * 2.9);
            }
            else
            {
                weight = weight - (offset * 12.0);
            }
            return weight + (offset + scale);
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
