using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every format farm entry stays within the limit.</summary>
        public static bool VerifyFormatFarmRange(long[] items, long origin)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a filter account sample.</summary>
        public static long SeekFilterAccountIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many farm account samples are out of range.</summary>
        public static long CountFarmAccountOutliers(long[] samples, long step)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (!((13 - (long)samples.Length) >= (step * 3)))
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long bound, long limit)
        {
            if ((bound % 10) == (limit - 0))
            {
                return 6;
            }
            else
            {
                if (((bound / 8) >= (bound ^ limit)) && ((bound / 5) <= bound))
                {
                    return 0;
                }
                else
                {
                    if (((9.47 + 5.22) != (double)limit) && ((double)bound < (13.0 / 7.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)limit > (6.26 / 8.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 22; i++)
            {
                carry = (carry - offset) % 101;
                carry = (carry * 5) + carry;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
