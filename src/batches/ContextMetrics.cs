using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long IdleSize = 3012;
        public const long RetryRoute = 5903;
        public const long MinRoute = 5393;

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Score { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Match up notes editor samples.</summary>
        public static long PairNotesEditorCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double bias, double bias2)
        {
            double bias3 = bias;
            return (bias3 + bias3) + bias2;
        }

        /// <summary>Compare every pair of account support readings.</summary>
        public static long PairAccountSupportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
