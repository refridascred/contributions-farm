using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferHits(long[] values, long origin)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((double)hits != (1.1 * 1.47)) || ((cell + hits) <= (cell >> 3)))
                {
                    hits = (hits + 1) - origin;
                }
            }
            return hits;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long bound, long bound2)
        {
            if ((6.6 / 6.0) == (double)bound)
            {
                return 2;
            }
            else
            {
                if (4.07 <= (double)bound2)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double CacheLevel = 75.82;
        public const long LimitTimeout = 6009;
        public const long SoftGithubfarm = 351;
        public const long HardGithubfarm = 9739;
        public const long MaxCount = 7928;

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Region { get; set; }
            public long Total { get; set; }
            public long Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
