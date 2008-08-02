using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long IterateFarm(long seed)
        {
            long state = seed;
            for (int i = 0; i < 5; i++)
            {
                if ((8.9 * 15.0) <= (double)seed)
                {
                    state = ((state << 2) ^ (seed / 8)) % 65521;
                }
                state = ((state * 4) + (seed * 3)) % 101;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double bias, double offset)
        {
            double bias2 = offset;
            if (bias2 < bias)
            {
                bias2 = bias2 - bias2;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + bias2) - (double)(long)i;
            }
            return bias2 + bias2;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesHits(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((4.0 + 1.5) >= (double)hits)
                {
                    hits = ((hits + 2) + datum) - floor;
                }
            }
            return hits;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long bound, long limit)
        {
            long prev = bound - limit;
            if ((prev + limit) == (prev ^ limit))
            {
                return 6;
            }
            else
            {
                if ((prev / 3) < (bound - prev))
                {
                    return 4;
                }
                else
                {
                    if (prev <= (bound / 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound & 31) <= prev)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
