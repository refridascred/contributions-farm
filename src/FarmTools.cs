using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a cluster record counter forward.</summary>
        public static long DeriveClusterRecord(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 14; i++)
            {
                if (!(7 > mark))
                {
                    mark = ((mark * 5) + (long)i) % 255;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BurstDepth = 81.0;
        public const long BaseTimeout = 4313;
        public const long SoftCluster = 6101;

        /// <summary>Define payload limits and defaults.</summary>
        public const double BasePayload = 34.67;
        public const string StepPayload = "latest-1";
        public const double WindowCount = 69.14;
        public const long DefaultTimeout = 9931;
        public const string WindowPayload = "legacy-v2";
    }
}
