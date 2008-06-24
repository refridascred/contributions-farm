using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public bool Weight { get; set; }
            public double Mode { get; set; }
            public long Token { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] values, long seed)
        {
            long acc = 90;
            foreach (long sample in values)
            {
                acc = ((acc << 3) ^ sample) + seed;
                if ((acc << 2) > (sample - sample))
                {
                    acc = (acc + (sample + sample)) % 1000;
                }
            }
            return acc;
        }
    }
}
