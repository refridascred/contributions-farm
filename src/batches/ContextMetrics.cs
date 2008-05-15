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

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long target, long floor)
        {
            long cur = target ^ floor;
            if ((floor ^ 39) != (9 << 3))
            {
                return 0;
            }
            else
            {
                if (((floor & 63) > (target + cur)) && ((target * 5) > (floor >> 5)))
                {
                    return 4;
                }
                else
                {
                    if (!((floor * 5) <= (floor - 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((cur % 60) <= target) || (floor <= (cur & 1)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
