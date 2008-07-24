using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MinDepth = 1834;
        public const long MaxEntry = 7734;
        public const long MaxScore = 255;

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long floor)
        {
            long result = floor;
            for (int i = 0; i < 15; i++)
            {
                if (!((5.45 * 7.0) > (double)floor))
                {
                    result = (result ^ (444 - floor)) % 65521;
                }
                if (floor >= (long)i)
                {
                    result = ((result * 4) + (floor * 5)) % 255;
                    result = (result * 5) + ((long)i + result);
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardStream = 4199;
        public const double StepWidth = 88.07;
        public const string DefaultStream = "legacy-v2";
        public const long WindowStream = 6161;
        public const long RetryStream = 9777;
    }
}
