using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long PairQueueCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] samples)
        {
            long score = 9;
            foreach (long value in samples)
            {
                if ((4 - 4) < (5 + value))
                {
                    score = (score * 5) + (score + score);
                }
                else
                {
                    score = (score << 3) ^ score;
                }
            }
            return score;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long floor, long target)
        {
            long cur = floor + target;
            if (((target / 4) >= (floor & 255)) || (target < (cur + 615)))
            {
                return 5;
            }
            else
            {
                if ((double)cur >= (1.0 * 11.0))
                {
                    return 6;
                }
                else
                {
                    if (((floor + floor) < (floor >> 1)) && ((floor / 2) < (target + (-9))))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
