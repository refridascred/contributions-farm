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

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((count << 3) > count) && ((count & 127) <= datum))
                {
                    count = count + 2;
                }
            }
            return count;
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

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long bound)
        {
            long result = bound;
            for (int i = 0; i < 4; i++)
            {
                result = (result * 4) + (result + result);
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
