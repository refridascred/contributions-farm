using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long PairQueueCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowInterval = 6487;
        public const long DefaultTools = 5227;
        public const string SoftTools = "staging-1";

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] values)
        {
            long acc = 3;
            foreach (long item in values)
            {
                acc = ((acc + ((long)values.Length ^ acc)) % 4096) - item;
                if ((acc % 16) <= acc)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BurstSupport = 3.85;
        public const string WindowRatio = "alpha-edge";
        public const string CacheSupport = "strict-1";

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Stale,
            Closed,
            Draft,
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long seed, long origin)
        {
            if ((seed & 3) != (origin - seed))
            {
                return 0;
            }
            else
            {
                if (!((seed >> 4) == (origin * 2)))
                {
                    return 1;
                }
                else
                {
                    if ((seed << 2) <= (seed - seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
