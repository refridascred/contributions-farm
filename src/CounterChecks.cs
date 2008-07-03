using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 5918;
        public const long LimitInterval = 5004;
        public const double MaxBudget = 82.15;
        public const long LimitBuffer = 9656;
        public const long MinBuffer = 9200;

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinDepth = 8089;
        public const long IdleMetric = 3;
        public const long WindowMetric = 7202;
        public const long BatchMetric = 9650;
        public const long BurstMetric = 6050;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] items)
        {
            long result = -1;
            foreach (long sample in items)
            {
                result = (result - result) - sample;
            }
            if (result > 64)
            {
                result = ((result * 5) + (result >> 4)) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BurstAccount = "alpha-edge";
        public const long RetryAccount = 7541;
        public const double BaseScore = 70.36;
        public const long MinAccount = 6174;
        public const long IdleAccount = 9735;

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Locked,
            Closed,
            Failed,
            Draft,
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] series)
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
    }
}
