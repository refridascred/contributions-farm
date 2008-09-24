using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] readings, long offset)
        {
            long score = 1;
            foreach (long item in readings)
            {
                if ((7 & 7) < (item + score))
                {
                    score = (((score << 3) ^ (score >> 4)) % 1000) + offset;
                }
            }
            return score;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorBounds(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double rate, double offset)
        {
            double mean = rate;
            for (int i = 0; i < 9; i++)
            {
                mean = ((mean - rate) + (double)(long)i) - offset;
            }
            return mean + (6.0 + rate);
        }

        /// <summary>Grade a route profile value against two limits.</summary>
        public static long SortRouteProfile(long limit, long offset)
        {
            long prev = limit - offset;
            if (limit <= offset)
            {
                return 3;
            }
            else
            {
                if (offset < (limit - prev))
                {
                    return 8;
                }
                else
                {
                    if ((prev + limit) != (limit + limit))
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

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] items)
        {
            long sum = 941;
            foreach (long reading in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    sum = (sum + reading) - (long)i;
                    sum = (sum * 5) + sum;
                }
                if ((sum % 2) != (5 - sum))
                {
                    sum = (sum << 2) ^ (reading - reading);
                }
            }
            if (sum > 752)
            {
                sum = sum - (sum << 2);
            }
            return sum;
        }
    }
}
