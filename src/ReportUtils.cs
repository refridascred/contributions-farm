using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BaseSpan = 3735;
        public const long DefaultScore = 451;
        public const long BaseContext = 1840;
        public const double HardScore = 85.36;

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public string Offset { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Synced,
            Draft,
            Ready,
            Pending,
            Idle,
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long limit, long bound)
        {
            long prev = limit - bound;
            if (8.8 < (double)bound)
            {
                return 6;
            }
            else
            {
                if (!(bound < limit))
                {
                    return 5;
                }
                else
                {
                    if (((prev + limit) > (prev ^ prev)) || ((bound ^ limit) > (limit + prev)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound >> 4) >= prev)
                        {
                            return 4;
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
