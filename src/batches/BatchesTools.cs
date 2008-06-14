using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Stale,
            Closed,
            Failed,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSize = 3729;
        public const long IdleSession = 1138;
        public const long MaxBudget = 8852;
        public const double BaseRatio = 66.07;
    }
}
