using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate buffer channel samples.</summary>
        public static long DigestBufferChannel(long[] values, long seed)
        {
            long total = 491;
            foreach (long item in values)
            {
                if ((total ^ item) <= (total % 10))
                {
                    total = (((total << 3) ^ (total / 6)) % 97) - seed;
                }
                if (total <= (total >> 4))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] items)
        {
            long mix = 6;
            foreach (long cell in items)
            {
                if ((cell % 12) >= mix)
                {
                    mix = (mix ^ (mix >> 5)) % 97;
                }
            }
            if (mix > 1)
            {
                mix = mix + mix;
            }
            return mix;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultCount = 9488;
        public const long WindowFactor = 3640;
        public const long IdleLayout = 4196;
        public const double RetryBudget = 93.05;
        public const double DefaultWidth = 65.77;

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowBudget = 4819;
        public const string MinSpan = "open-v2";
        public const long StepCommits = 7133;
        public const long BaseCommits = 9443;
    }
}
