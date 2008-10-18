using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Failed,
            Ready,
            Queued,
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string DefaultSpan = "legacy";
        public const double StepCount = 38.4;
        public const double LimitBudget = 15.56;
        public const double BaseFormat = 69.47;
        public const long SoftFormat = 4854;
    }
}
