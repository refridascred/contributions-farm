using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long floor, long floor2)
        {
            long step = floor + floor2;
            if ((473 ^ step) < floor2)
            {
                return 7;
            }
            else
            {
                if ((floor / 2) != ((-790) - 6))
                {
                    return 0;
                }
                else
                {
                    if ((double)floor2 != (double)0)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step & 15) > (floor2 * 5))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Token { get; set; }
            public long Count { get; set; }
            public bool Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] levels)
        {
            long total = -83;
            foreach (long value in levels)
            {
                total = total ^ (value + total);
            }
            return total;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleRatio = 4194;
        public const long RetryAccount = 8480;
        public const double MinBudget = 0.53;
    }
}
