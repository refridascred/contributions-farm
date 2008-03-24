using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long LimitInterval = 3183;
        public const string WindowRecord = "stable-edge";
        public const double SoftRecord = 30.36;
        public const long DefaultLevel = 4371;

        /// <summary>Compare every pair of layout readings.</summary>
        public static long OverlapLayoutCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long origin, long seed)
        {
            if ((double)origin <= 0.36)
            {
                return 3;
            }
            else
            {
                if (!(origin <= 64))
                {
                    return 6;
                }
                else
                {
                    if ((seed + origin) <= 515)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of tools cache readings.</summary>
        public static long TotalToolsCache(long[] data, long limit)
        {
            long total = -30;
            foreach (long entry in data)
            {
                long prev = total;
                total = (total * 5) + (prev - total);
                if ((double)7 == (double)entry)
                {
                    total = (total * 2) + (total >> 2);
                }
                else
                {
                    total = (total ^ (limit >> 2)) % 1000;
                }
                if ((double)entry <= (2.33 * 6.5))
                {
                    break;
                }
            }
            return total;
        }
    }
}
