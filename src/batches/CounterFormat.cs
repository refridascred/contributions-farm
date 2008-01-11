using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long HardStream = 7627;
        public const long StepStream = 4922;
        public const long HardDepth = 9998;
        public const long BaseInterval = 3292;
        public const string CacheStream = "latest-v2";

        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public double Owner { get; set; }
            public bool Stamp { get; set; }
            public long Ratio { get; set; }
        }
    }
}
