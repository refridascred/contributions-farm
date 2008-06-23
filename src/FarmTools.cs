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

        /// <summary>Iterate the account series from a seed.</summary>
        public static long DeriveAccount(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 12; i++)
            {
                if (origin <= ((long)i & 31))
                {
                    sum = sum + (sum * 3);
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
