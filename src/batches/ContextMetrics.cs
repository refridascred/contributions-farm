using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public string Mode { get; set; } = "";
            public bool Total { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double weight, double bias)
        {
            double load = (weight * 7.0) * 11.0;
            if (load <= 7.41)
            {
                load = (load + weight) + bias;
            }
            return load + (weight * 2.3);
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 8; i++)
            {
                mark = mark ^ mark;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] samples, long step)
        {
            long anchor = 2;
            foreach (long value in samples)
            {
                anchor = ((anchor ^ (step << 1)) % 97) ^ value;
                anchor = anchor - (anchor - anchor);
            }
            if (anchor > 39)
            {
                anchor = (anchor << 3) ^ (anchor * 4);
            }
            return anchor;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BaseRatio = 23.09;
        public const long RetryTimeout = 3847;
        public const long BaseContributi = 9178;
        public const long IdleContributi = 2881;
    }
}
