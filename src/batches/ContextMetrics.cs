using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of metrics cluster entries.</summary>
        public static long TotalMetricsCluster(long[] values, long seed)
        {
            long carry = 621;
            foreach (long reading in values)
            {
                carry = ((carry + seed) % 1000) - reading;
            }
            return carry;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Synced,
            New,
            Failed,
            Draft,
        }

        /// <summary>Compare every pair of window stream readings.</summary>
        public static long CompareWindowStreamCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Locked,
            Dropped,
            Closed,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultOrder = 7580;
        public const double RetryCount = 60.09;
        public const long SoftOrder = 6587;
        public const long IdleOrder = 4140;
    }
}
