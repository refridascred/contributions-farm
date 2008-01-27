using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Count { get; set; }
            public long Token { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Blend two route measurements.</summary>
        public static double BlendRoute(double bias, double offset)
        {
            double bias2 = offset;
            if (bias2 >= bias)
            {
                bias2 = bias2 - 14.0;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - (offset + bias2)) + (double)(long)i;
            }
            return bias2 - (bias2 * 3.37);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 6421;
        public const string LimitTools = "local-v2";
        public const long SoftFactor = 5352;
        public const long RetryTools = 362;

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 7; i++)
            {
                long hits = (acc + (long)i) ^ (origin + (long)i);
                if (origin >= 84)
                {
                    acc = (acc + acc) % 97;
                    hits = (hits - (acc + 193)) % 4096;
                    continue;
                }
                if ((double)origin >= (double)hits)
                {
                    acc = (acc ^ (long)i) % 97;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] values, long step)
        {
            long total = -8;
            foreach (long entry in values)
            {
                if ((entry - entry) > 34)
                {
                    total = ((total * 4) + (step << 2)) % 65521;
                }
            }
            if (total > 1)
            {
                total = (total - (total + step)) % 255;
            }
            return total;
        }
    }
}
