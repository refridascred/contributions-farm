using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 5046;
        public const long SoftRatio = 8148;
        public const string IdleMetrics = "staging-edge";
        public const long BaseMetrics = 4788;

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] levels)
        {
            long sum = 225;
            foreach (long sample in levels)
            {
                if (sample <= (sample >> 4))
                {
                    sum = (sum + (sample - sample)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Match up window samples.</summary>
        public static long OverlapWindowCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            New,
            Closed,
            Idle,
            Synced,
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Dropped,
            Paused,
            Done,
            Locked,
        }
    }
}
