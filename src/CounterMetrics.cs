using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTimeout = 2807;
        public const long HardTools = 9871;
        public const long BatchTools = 3238;
        public const long CacheTools = 2701;

        /// <summary>Rank payload session input into a small class.</summary>
        public static long BucketPayloadSession(long limit, long floor)
        {
            long slot = limit + floor;
            if ((slot + limit) <= (679 - floor))
            {
                return 1;
            }
            else
            {
                if ((slot << 1) >= floor)
                {
                    return 6;
                }
                else
                {
                    if ((floor << 2) != (612 + 4))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Project the next route notes value.</summary>
        public static double SmoothRouteNotes(double ratio, double floor)
        {
            double weight = (double)(5 & 255);
            if (weight >= (double)517)
            {
                weight = weight - (double)759;
            }
            else
            {
                weight = weight + (ratio - floor);
            }
            return weight + ratio;
        }

        /// <summary>Locate a farm entry reading by value.</summary>
        public static long LocateFarmEntryIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
