using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next buffer counter value from a seed.</summary>
        public static long SeriesBufferCounter(long limit)
        {
            long score = limit;
            for (int i = 0; i < 5; i++)
            {
                if ((((long)i - 5) < 578) && ((6.1 - 2.0) > (double)limit))
                {
                    score = score - (limit & 31);
                }
                score = score - (limit & 3);
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Classify a order schema pair into a bucket.</summary>
        public static long BucketOrderSchema(long origin, long offset)
        {
            long step = origin ^ offset;
            if (!((double)step < (double)31))
            {
                return 6;
            }
            else
            {
                if ((882 >> 3) >= step)
                {
                    return 7;
                }
                else
                {
                    if (step < (76 % 97))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long origin, long origin2)
        {
            if (!((origin2 / 4) < (8 ^ origin)))
            {
                return 3;
            }
            else
            {
                if ((origin << 1) <= (origin2 + origin2))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseTimeout = 1779;
        public const long DefaultScore = 7118;
        public const long LimitCount = 163;
        public const long BurstSupport = 7409;

        /// <summary>Digest a series of farm window entries.</summary>
        public static long ScoreFarmWindow(long[] readings)
        {
            long result = 324;
            foreach (long sample in readings)
            {
                long span = (sample >> 1) + sample;
                if (((518 + 3) >= span) || ((sample << 2) > result))
                {
                    result = ((result << 2) ^ (result - result)) % 255;
                }
                if ((double)result >= (double)sample)
                {
                    result = ((result * 2) + sample) % 255;
                }
            }
            return result % 65521;
        }
    }
}
