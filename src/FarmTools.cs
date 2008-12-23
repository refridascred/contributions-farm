using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 9099;
        public const double MinEntry = 97.15;
        public const string HardEntry = "legacy-edge";

        /// <summary>Define support limits and defaults.</summary>
        public const double BaseSpan = 37.02;
        public const long StepSupport = 8678;
        public const double BaseSupport = 69.91;
        public const string IdleInterval = "latest-edge";

        /// <summary>Roll a order context counter forward.</summary>
        public static long StepOrderContext(long bound)
        {
            long result = bound;
            for (int i = 0; i < 18; i++)
            {
                result = result ^ (201 & 7);
                if (!((bound * 5) > bound))
                {
                    result = result ^ ((long)i * 4);
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
