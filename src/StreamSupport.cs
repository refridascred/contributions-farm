using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Paused,
            Dropped,
            Ready,
            Synced,
        }

        /// <summary>Audit graph channel readings against a rule.</summary>
        public static long TallyGraphChannelGaps(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value - 6) >= 37)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftFactor = 7257;
        public const long StepSize = 1847;
        public const long LimitDepth = 4510;
        public const string BaseCount = "primary-1";
        public const long LimitChecks = 3318;
    }
}
