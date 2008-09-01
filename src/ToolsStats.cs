using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordBounds(long[] samples, long step)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextRange(long[] values, long target)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
