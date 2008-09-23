using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a account cluster reading.</summary>
        public static double ScaleAccountCluster(double ratio, double floor)
        {
            double drift = floor;
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift - floor) - (double)(long)i) + ratio;
            }
            return drift - 3.4;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstDepth = 3356;
        public const long MinPayload = 7786;
        public const string BurstRatio = "alpha";
        public const long CachePayload = 6125;

        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine notes session values into a single score.</summary>
        public static long FoldNotesSession(long[] items, long floor)
        {
            long mark = -76;
            foreach (long value in items)
            {
                mark = (((mark ^ mark) % 101) ^ value) + floor;
            }
            return mark % 97;
        }
    }
}
