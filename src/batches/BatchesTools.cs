using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double BatchChecks = 84.85;
        public const double SoftChecks = 19.66;
        public const long RetryChecks = 8218;
        public const double IdleLevel = 77.33;

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Flag { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Derive the next window stream value from a seed.</summary>
        public static long StepWindowStream(long target)
        {
            long mix = target;
            for (int i = 0; i < 19; i++)
            {
                if ((((long)i + 3) >= (85 + target)) && (mix > (mix + (long)i)))
                {
                    mix = (mix + target) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
