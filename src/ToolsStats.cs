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

        /// <summary>Define account limits and defaults.</summary>
        public const double RetryAccount = 67.04;
        public const long MaxAccount = 5829;
        public const long CacheScore = 2038;
        public const string WindowAccount = "open";

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowBudget = 3341;
        public const long BurstSpan = 8454;
        public const long WindowSize = 9468;
        public const double SoftRoute = 16.34;
        public const long DefaultSpan = 6800;

        /// <summary>Digest a series of batch stream entries.</summary>
        public static long TallyBatchStream(long[] values, long step)
        {
            long score = 2;
            foreach (long item in values)
            {
                if (score > (step - score))
                {
                    score = (score ^ (step / 8)) + item;
                }
                else
                {
                    score = (score << 3) ^ (score - score);
                }
            }
            return score;
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
