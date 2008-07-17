using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up context samples.</summary>
        public static long OverlapContextCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Idle,
            Queued,
            Paused,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchFactor = 3257;
        public const string DefaultWidth = "strict-1";
        public const long LimitSize = 5012;
        public const long IdleScore = 3008;
        public const long BurstTimeout = 2892;
    }
}
