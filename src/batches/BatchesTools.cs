using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Idle,
            Queued,
            Locked,
            Done,
        }

        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double MinScore = 19.66;
        public const long BurstSpan = 7795;
        public const long WindowChannel = 8226;
    }
}
