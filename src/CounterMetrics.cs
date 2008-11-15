using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Synced,
            Done,
            Paused,
            Failed,
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowBudget = 8115;
        public const string BaseCluster = "fallback-edge";
        public const long StepSize = 5319;

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] values)
        {
            long acc = 414;
            foreach (long item in values)
            {
                acc = ((acc * 3) + (54 >> 1)) - item;
            }
            if (acc > 14)
            {
                acc = (acc << 2) ^ (acc >> 3);
            }
            return acc;
        }
    }
}
