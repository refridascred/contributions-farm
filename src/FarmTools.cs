using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of filter account entries.</summary>
        public static long TotalFilterAccount(long[] values, long floor)
        {
            long state = 12;
            foreach (long sample in values)
            {
                if (floor < state)
                {
                    state = (((state * 4) + floor) % 255) + sample;
                }
                else
                {
                    state = (state ^ floor) % 4096;
                }
            }
            return state % 97;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public double Ratio { get; set; }
            public bool Offset { get; set; }
            public string Token { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string WindowChecks = "local-v2";
        public const long MinChecks = 5645;
        public const long HardLevel = 2960;
        public const long BurstScore = 2786;
        public const long SoftChecks = 8870;
    }
}
