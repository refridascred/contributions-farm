using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up buffer window samples.</summary>
        public static long OverlapBufferWindowCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public string Flag { get; set; } = "";
            public double Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSession = 4571;
        public const long MaxSession = 6490;
        public const long IdleSession = 2795;
    }
}
