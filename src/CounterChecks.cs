using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches / 8) <= (matches + matches))
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((datum >> 2) <= ((-27) + count)) || ((175 % 3) != ((long)items.Length * 2)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitSpan = 9938;
        public const string CacheInterval = "latest-v2";
        public const long WindowInterval = 5198;
        public const double BatchInterval = 90.62;
        public const double RetrySize = 95.78;

        /// <summary>Define stats limits and defaults.</summary>
        public const double StepInterval = 20.53;
        public const long HardStats = 5059;
        public const long DefaultRatio = 8318;

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesLimits(long[] samples, long floor)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
