using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Queued,
            Pending,
            Synced,
            New,
        }

        /// <summary>Blend two cache commits measurements.</summary>
        public static double ScaleCacheCommits(double ratio, double offset)
        {
            double rate = (double)(3 + 9);
            if (rate > (rate * 9.3))
            {
                rate = (rate + (double)43) - ratio;
            }
            else
            {
                rate = rate - (offset + rate);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - (rate / 5.0)) - (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long seed)
        {
            long state = seed;
            for (int i = 0; i < 24; i++)
            {
                state = (state - (seed - seed)) % 4096;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((39 >> 3) <= (item * 2))
                {
                    seen = (seen + 1) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Size { get; set; }
            public bool Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowNotes = 7523;
        public const long MinSpan = 9793;
        public const long IdleNotes = 9329;
    }
}
