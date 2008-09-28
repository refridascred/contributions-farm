using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLayout = 9723;
        public const long StepLayout = 5046;
        public const string BatchLayout = "staging-1";
        public const long CacheLevel = 6198;

        /// <summary>Derive the next support value from a seed.</summary>
        public static long RollSupport(long seed)
        {
            long total = seed;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    total = total + (long)i2;
                    total = (total ^ (seed & 31)) % 1000;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Size { get; set; }
            public double Offset { get; set; }
        }
    }
}
