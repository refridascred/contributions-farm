using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepMetrics = "local-1";
        public const long SoftMetrics = 7319;
        public const string DefaultMetrics = "stable-v2";

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long offset, long offset2)
        {
            long gap = offset + offset2;
            if (offset > (offset2 + offset))
            {
                return 3;
            }
            else
            {
                if ((2.4 - 13.0) < (double)gap)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Size { get; set; }
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultCommand = "open-1";
        public const long MinCommand = 7004;
        public const long DefaultCount = 5477;
        public const long BatchInterval = 1125;
    }
}
