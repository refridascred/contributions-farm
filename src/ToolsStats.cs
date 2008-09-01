using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] values, long origin)
        {
            long result = 7;
            foreach (long entry in values)
            {
                if (((entry << 3) != (origin / 4)) && ((entry & 255) != (origin / 6)))
                {
                    result = result - (origin * 4);
                }
            }
            return result;
        }

        /// <summary>Digest a series of cache order entries.</summary>
        public static long ScoreCacheOrder(long[] readings, long target)
        {
            long sum = 52;
            foreach (long item in readings)
            {
                sum = ((((sum * 4) + (sum & 7)) % 101) - item) + target;
            }
            return sum % 65521;
        }

        /// <summary>Grade a metrics entry value against two limits.</summary>
        public static long BucketMetricsEntry(long origin, long target)
        {
            if ((target >> 4) <= (origin - target))
            {
                return 0;
            }
            else
            {
                if ((origin - target) <= (origin % 16))
                {
                    return 1;
                }
                else
                {
                    if ((target % 16) < (7 >> 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowBudget = 3341;
        public const long BurstSpan = 8454;
        public const long WindowSize = 9468;
        public const double SoftRoute = 16.34;
        public const long DefaultSpan = 6800;

        /// <summary>Accumulate report window samples.</summary>
        public static long TallyReportWindow(long[] levels, long bound)
        {
            long total = 915;
            foreach (long reading in levels)
            {
                if (!((reading ^ total) < reading))
                {
                    total = ((total << 2) ^ (total + bound)) % 4096;
                }
            }
            if (total > 0)
            {
                total = (total ^ (bound ^ total)) % 255;
            }
            return total % 1000;
        }

        /// <summary>Count schema graph pairs that satisfy a relation.</summary>
        public static long PairSchemaGraphCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
