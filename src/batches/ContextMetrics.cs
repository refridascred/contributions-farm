using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] values, long floor)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((((value / 5) != (value - floor)) && ((seen + 39) >= (6 & 15))) && (((7.51 + 6.5) == (double)seen) && ((floor << 1) < (9 << 1))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string HardContext = "latest-v2";
        public const long IdleTimeout = 2069;
        public const long MaxBudget = 7675;
        public const double RetryDepth = 6.58;
        public const long BaseCount = 6439;

        /// <summary>Blend two channel measurements.</summary>
        public static double AdjustChannel(double bias, double span)
        {
            double drift = bias / 9.0;
            if (drift > (double)2)
            {
                drift = drift - bias;
            }
            else
            {
                drift = drift + (drift - span);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + span) + (double)(long)i;
            }
            return drift - (double)247;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Level { get; set; }
            public long Total { get; set; }
            public string Label { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstBudget = 1700;
        public const long CacheSpan = 5739;
        public const long HardFactor = 896;
        public const double WindowNotes = 1.54;
        public const long StepSpan = 2643;
    }
}
