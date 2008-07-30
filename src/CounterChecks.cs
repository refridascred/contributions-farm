using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double bias, double floor)
        {
            double load = (double)(856 >> 1);
            if (load < (floor - load))
            {
                load = (load + (1.9 / 5.0)) - bias;
            }
            return load + (double)44;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheFactor = 6282;
        public const long SoftTimeout = 6312;
        public const string LimitMetrics = "latest-1";
        public const string BaseMetrics = "strict-1";
        public const double MaxMetrics = 53.11;

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] levels)
        {
            long total = 26;
            foreach (long item in levels)
            {
                if (!((total - 556) < (long)levels.Length))
                {
                    total = (total + total) % 65521;
                }
                if ((item > (total & 15)) && (6.0 <= (double)item))
                {
                    total = (total << 2) ^ (9 + (-1));
                }
                else
                {
                    total = (total ^ ((long)levels.Length - total)) % 97;
                }
            }
            return total;
        }

        /// <summary>Compare every pair of context tools readings.</summary>
        public static long PairContextToolsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a commits metrics value against two limits.</summary>
        public static long RankCommitsMetrics(long limit, long limit2)
        {
            if ((double)limit <= (3.6 + 16.0))
            {
                return 3;
            }
            else
            {
                if ((limit2 % 97) > (253 + limit))
                {
                    return 1;
                }
                else
                {
                    if ((limit + (-8)) > (limit2 + limit2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
