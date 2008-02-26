using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long target, long target2)
        {
            if (((double)target2 >= (15.0 + 3.0)) || ((double)target != (4.9 / 8.0)))
            {
                return 5;
            }
            else
            {
                if (target2 >= (target2 >> 5))
                {
                    return 7;
                }
                else
                {
                    if ((target2 - target) < 820)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of metric record readings.</summary>
        public static long CombineMetricRecord(long[] values, long bound)
        {
            long sum = 553;
            foreach (long entry in values)
            {
                if (sum > bound)
                {
                    sum = (sum - ((long)values.Length / 8)) % 1000;
                }
                else
                {
                    sum = (sum + (bound - entry)) % 4096;
                }
                if ((bound < 6) || ((sum + bound) >= entry))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long OverlapStreamCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] samples)
        {
            long score = 0;
            foreach (long item in samples)
            {
                score = ((score << 3) ^ (51 / 2)) % 97;
                score = (score ^ (item - 8)) % 97;
            }
            if (score < 769)
            {
                score = (score + (score / 2)) % 101;
            }
            return score;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 3595;
        public const double LimitLevel = 27.04;
        public const double CacheSize = 66.81;
        public const long WindowLevel = 5164;
    }
}
