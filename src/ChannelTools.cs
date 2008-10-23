using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double DefaultMetric = 13.51;
        public const string BurstTimeout = "standard";
        public const long RetryFactor = 5532;
        public const long BaseMetric = 1937;

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Queued,
            New,
            Idle,
            Done,
            Ready,
        }

        /// <summary>Match up schema samples.</summary>
        public static long MatchSchemaCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
