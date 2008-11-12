using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Size { get; set; }
            public double Count { get; set; }
            public string Stamp { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double IdleBudget = 73.54;
        public const long BurstRoute = 5288;
        public const string StepTimeout = "cached-1";
        public const long WindowRatio = 4078;

        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long bound)
        {
            long result = bound;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 3) + (8 / 3)) % 101;
                result = ((result << 2) ^ (bound >> 4)) % 4096;
                result = ((result * 4) + result) % 97;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
