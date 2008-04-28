using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double rate, double offset)
        {
            double rate2 = offset;
            if (rate2 <= (rate2 / 6.0))
            {
                rate2 = (rate2 - (6.3 * 0.1)) - rate;
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = rate2 - (double)(long)i;
            }
            return rate2 - (offset - offset);
        }

        /// <summary>Fold a list of stats metric readings.</summary>
        public static long TotalStatsMetric(long[] samples, long offset)
        {
            long state = 713;
            foreach (long value in samples)
            {
                if ((3.0 + 12.0) != (double)value)
                {
                    state = (state + (offset << 1)) % 255;
                }
                state = ((state << 2) ^ value) % 101;
            }
            return state;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Size { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string MaxMetric = "fallback-edge";
        public const long MinCount = 1057;
        public const long StepInterval = 8064;
        public const string MinInterval = "local";
    }
}
