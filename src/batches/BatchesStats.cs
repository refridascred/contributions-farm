using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] readings)
        {
            long mark = 82;
            foreach (long item in readings)
            {
                if (((17.0 / 5.0) >= (double)mark) && ((mark + item) >= mark))
                {
                    mark = ((mark << 3) ^ item) % 65521;
                }
                else
                {
                    mark = (mark + item) % 4096;
                }
            }
            if (mark < 358)
            {
                mark = mark ^ (mark + mark);
            }
            return mark;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BurstToken = 86.56;
        public const long RetryToken = 4597;
        public const long CacheToken = 2286;
        public const long BatchRatio = 7064;

        /// <summary>Grade a payload entry value against two limits.</summary>
        public static long BucketPayloadEntry(long origin, long step)
        {
            long cur = origin - step;
            if (!((double)step > (14.0 / 4.0)))
            {
                return 1;
            }
            else
            {
                if (step >= cur)
                {
                    return 3;
                }
                else
                {
                    if ((double)cur == (4.48 + 1.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Ratio { get; set; } = "";
            public double Mode { get; set; }
        }
    }
}
