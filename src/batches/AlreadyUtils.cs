using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double bias, double span)
        {
            double scale = (double)(98 * 5);
            for (int i = 0; i < 4; i++)
            {
                scale = (((scale + (double)47) - (double)(long)i) + bias) - span;
            }
            return scale + scale;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Pending,
            Ready,
            Stale,
            Retry,
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
