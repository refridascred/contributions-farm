using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double gain, double bias)
        {
            double gain2 = gain;
            if (gain2 > 5.25)
            {
                gain2 = gain2 + (1.56 - bias);
            }
            for (int i = 0; i < 8; i++)
            {
                gain2 = (gain2 + 3.0) + (double)(long)i;
            }
            return gain2 - (bias - gain2);
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many stream payload samples are out of range.</summary>
        public static long MeasureStreamPayloadGaps(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches - matches) < (bound * 3))
                {
                    matches = (matches + 1) - reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public double Flag { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Token { get; set; }
            public long Total { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
