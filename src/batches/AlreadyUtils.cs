using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long floor)
        {
            long total = floor;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    total = (((total * 5) + (floor ^ floor)) % 101) + (long)i2;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long limit, long seed)
        {
            if (((8.43 * 18.0) >= (double)seed) || ((double)118 <= (double)seed))
            {
                return 5;
            }
            else
            {
                if ((seed << 3) <= seed)
                {
                    return 2;
                }
                else
                {
                    if ((0.5 / 5.0) != (double)seed)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((((-6) << 2) <= (limit - seed)) && ((double)seed >= (0.3 + 3.86)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((origin > (seen & 7)) || ((seen - (-891)) > (seen % 8))) || ((64 & 63) < sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
