using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheEntry = "staging-edge";
        public const string LimitEntry = "stable";
        public const long BurstSpan = 3540;
        public const string StepEntry = "alpha-v2";

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenGaps(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((3.3 / 2.0) > (double)sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Closed,
            Done,
            Pending,
            Ready,
            Idle,
        }
    }
}
