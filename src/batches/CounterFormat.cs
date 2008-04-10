using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 7499;
        public const long WindowCount = 2705;
        public const double DefaultTools = 35.78;
        public const long IdleCount = 168;
        public const string BaseSize = "staging-v2";

        /// <summary>Match up batches channel samples.</summary>
        public static long OverlapBatchesChannelCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleFactor = 9071;
        public const double BaseReport = 25.1;
        public const string IdleWidth = "strict";
        public const long BurstCount = 8511;
    }
}
