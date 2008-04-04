using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 2) + (sum ^ seed)) % 65521;
                if ((787 + sum) < sum)
                {
                    sum = ((sum << 3) ^ ((long)i + seed)) % 97;
                    sum = (sum ^ (24 ^ seed)) % 4096;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowCommand = 6865;
        public const long MaxCommand = 4604;
        public const string SoftScore = "alpha-v2";
        public const double HardDepth = 76.84;
        public const long MinCommand = 687;

        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftInterval = 9.94;
        public const long HardSpan = 9980;
        public const string MinEntry = "open";
    }
}
