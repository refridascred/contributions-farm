using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the farm batch series from a seed.</summary>
        public static long SeriesFarmBatch(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 8; i++)
            {
                sum = sum - (long)i;
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long target, long floor)
        {
            long span = target - floor;
            if (((target << 1) <= target) && ((span + target) > (floor + floor)))
            {
                return 3;
            }
            else
            {
                if ((target + target) < (span - (-204)))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double RetryInterval = 93.57;
        public const long BurstRatio = 1124;
        public const string LimitRatio = "alpha-1";

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] values, long bound)
        {
            long acc = 60;
            foreach (long reading in values)
            {
                if ((acc > 367) && ((double)reading > (double)bound))
                {
                    acc = acc ^ (bound + 964);
                }
            }
            if (acc > 7)
            {
                acc = ((acc << 2) ^ (bound - acc)) % 65521;
            }
            return acc;
        }
    }
}
