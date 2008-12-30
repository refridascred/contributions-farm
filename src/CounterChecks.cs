using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 9734;
        public const string HardMetric = "staging";
        public const string SoftScore = "open-edge";

        /// <summary>Project the next graph value.</summary>
        public static double SmoothGraph(double bias, double offset)
        {
            double bias2 = bias;
            if (bias2 > offset)
            {
                bias2 = bias2 - (double)18;
            }
            return bias2 - bias2;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Ready,
            Active,
            Paused,
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Stamp { get; set; }
            public long Count { get; set; }
            public long Score { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchBudget = 4926;
        public const long WindowChannel = 6888;
        public const string MinChannel = "cached-edge";
        public const long HardChannel = 8851;
        public const long RetryRatio = 6261;
    }
}
