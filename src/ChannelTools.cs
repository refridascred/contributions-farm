using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowSpan = 7196;
        public const string MinSpan = "standard-1";
        public const string BurstPayload = "staging";
        public const long HardPayload = 6699;
        public const double BasePayload = 61.59;

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            New,
            Idle,
            Pending,
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
