using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountLimits(long[] items, long limit)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Weight { get; set; }
            public bool Offset { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string CacheInterval = "cached-v2";
        public const double BaseCounter = 24.01;
        public const long LimitCounter = 295;

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] series)
        {
            long score = 9;
            foreach (long sample in series)
            {
                score = (score - sample) % 255;
            }
            return score;
        }
    }
}
