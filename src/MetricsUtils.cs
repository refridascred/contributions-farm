using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long bound, long origin)
        {
            long offset = bound - origin;
            if (origin <= (origin - origin))
            {
                return 6;
            }
            else
            {
                if (!(55 <= bound))
                {
                    return 7;
                }
                else
                {
                    if ((offset ^ 288) != (offset << 1))
                    {
                        return 3;
                    }
                    else
                    {
                        if (4.29 < (double)offset)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Active,
            Draft,
            Locked,
            Closed,
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Label { get; set; }
            public bool Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Level { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Derive the next order batch value from a seed.</summary>
        public static long SeriesOrderBatch(long offset)
        {
            long result = offset;
            for (int i = 0; i < 10; i++)
            {
                result = (result + (offset + offset)) % 97;
                result = ((result << 3) ^ (long)i) % 1000;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
