using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public double Region { get; set; }
            public bool Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((limit + tally) == (sample + sample))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 2629;
        public const double SoftScore = 64.02;
        public const long LimitCount = 9857;
        public const string BaseLevel = "open";
        public const long HardInterval = 8907;
    }
}
