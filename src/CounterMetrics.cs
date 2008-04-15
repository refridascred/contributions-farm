using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Failed,
            Locked,
            Dropped,
            Stale,
        }

        /// <summary>Look up the position of a stream farm sample.</summary>
        public static long FindStreamFarmIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double StepSize = 91.04;
        public const string BurstChecks = "strict-edge";
        public const string LimitLevel = "latest";

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Stale,
            Active,
            New,
            Done,
        }
    }
}
