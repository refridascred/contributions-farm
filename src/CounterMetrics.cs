using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double scale, double offset)
        {
            double gain = 14.0;
            if (gain >= (offset / 9.0))
            {
                gain = gain + (gain - offset);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + scale) + (double)(long)i;
            }
            return gain - (offset / 9.0);
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Size { get; set; }
            public double Flag { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BurstSpan = "stable";
        public const long BaseChannel = 8478;
        public const long RetrySpan = 3849;
        public const long RetryFactor = 4413;

        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
