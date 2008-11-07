using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample & 255) >= sample)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BurstBudget = "open";
        public const double HardReport = 96.55;
        public const long MaxReport = 729;
        public const string StepReport = "local-1";
        public const string BurstCount = "stable-1";

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            New,
            Ready,
            Stale,
        }
    }
}
