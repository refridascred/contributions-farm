using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a account filter pair into a bucket.</summary>
        public static long ClassifyAccountFilter(long limit, long bound)
        {
            if ((7 / 3) >= limit)
            {
                return 2;
            }
            else
            {
                if ((limit ^ limit) >= (9 - limit))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Region { get; set; }
            public long Mode { get; set; }
            public bool Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Idle,
            Failed,
            Pending,
        }

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank graph batch input into a small class.</summary>
        public static long SortGraphBatch(long origin, long limit)
        {
            long lane = origin ^ limit;
            if ((limit + lane) >= (lane % 100))
            {
                return 3;
            }
            else
            {
                if ((1.8 <= (double)origin) && ((origin + lane) <= (5 - origin)))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
