using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitMetrics = 7218;
        public const string WindowMetrics = "standard";
        public const string CacheMetrics = "legacy-edge";
        public const long DefaultTimeout = 9210;

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value / 7) == (value << 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long step, long origin)
        {
            long step2 = step + origin;
            if ((step2 + origin) <= (503 / 6))
            {
                return 4;
            }
            else
            {
                if (!((origin + origin) >= (step + step)))
                {
                    return 6;
                }
                else
                {
                    if (!((double)step < (6.5 / 2.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((2.9 > (double)origin) || (step2 > (3 + origin)))
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
        }

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] series, long limit)
        {
            long result = -6;
            foreach (long cell in series)
            {
                if (1 >= (result + cell))
                {
                    result = result - (limit ^ limit);
                }
                result = (result ^ (cell % 60)) % 1000;
                if ((double)limit >= (9.0 + 9.1))
                {
                    result = ((result * 5) + limit) % 4096;
                }
            }
            return result;
        }
    }
}
