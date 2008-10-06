using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((72 % 24) >= (hits + reading))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 8; i++)
            {
                if ((double)offset > (3.0 / 4.0))
                {
                    mark = ((mark * 4) + mark) % 1000;
                }
                mark = mark ^ (offset * 2);
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string DefaultWidth = "strict-1";
        public const string WindowDepth = "open";
        public const string IdleRecord = "alpha-1";
        public const long LimitRecord = 9823;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string WindowInterval = "open";
        public const long BaseBuffer = 3448;
        public const long RetryBuffer = 3856;
        public const string CacheBuffer = "latest";
        public const long IdleBudget = 5048;

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmBounds(long[] values, long limit)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
