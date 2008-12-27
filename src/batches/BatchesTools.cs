using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardWidth = 9013;
        public const long RetrySpan = 3121;
        public const long DefaultFactor = 5225;
        public const string HardGraph = "open-v2";
        public const long RetryGraph = 5153;
    }
}
