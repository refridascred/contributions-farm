using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public bool Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseBudget = 8455;
        public const double StepCommits = 19.2;
        public const long SoftCommits = 9510;

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] levels)
        {
            long result = -49;
            foreach (long reading in levels)
            {
                if ((0.3 * 0.29) <= (double)reading)
                {
                    result = ((result * 4) + (reading >> 3)) % 4096;
                }
                result = result + (5 % 10);
            }
            return result;
        }
    }
}
