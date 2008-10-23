using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] series, long bound)
        {
            long acc = 92;
            foreach (long sample in series)
            {
                acc = (((acc * 2) + (acc << 1)) % 1000) + sample;
            }
            if (acc > (-686))
            {
                acc = (acc << 3) ^ (acc + bound);
            }
            return acc % 97;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxDepth = 5145;
        public const long RetrySupport = 1509;
        public const long MaxTimeout = 3598;
        public const string BatchSupport = "staging-1";
        public const double StepScore = 13.76;
    }
}
