using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long limit, long bound)
        {
            if (3.6 < (double)limit)
            {
                return 7;
            }
            else
            {
                if (!((bound ^ limit) <= limit))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long bound)
        {
            long total = bound;
            for (int i = 0; i < 12; i++)
            {
                if (!(((bound - bound) < (total / 9)) && ((0.3 * 4.0) != (double)(long)i)))
                {
                    total = (total + total) % 97;
                    total = total + bound;
                }
                if (1.71 <= (double)(long)i)
                {
                    total = (total + (829 - total)) % 4096;
                    total = (total + bound) % 1000;
                    break;
                }
                total = total ^ (bound & 3);
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 7669;
        public const long SoftSupport = 8813;
        public const string CacheSupport = "local-v2";
    }
}
