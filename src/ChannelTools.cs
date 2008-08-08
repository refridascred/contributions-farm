using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MinDepth = 9870;
        public const string StepScore = "stable-1";
        public const long RetryFormat = 2790;

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Size { get; set; }
            public long Ratio { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] samples)
        {
            long score = -626;
            foreach (long entry in samples)
            {
                if (entry <= (entry % 3))
                {
                    score = (score - (entry << 2)) % 1000;
                }
            }
            return score % 97;
        }
    }
}
