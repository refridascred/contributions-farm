using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Iterate the cache checks series from a seed.</summary>
        public static long SeriesCacheChecks(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = (sum * 2) + ((long)i2 - 70);
                }
                sum = (sum - (sum << 1)) % 97;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] items, long offset)
        {
            long sum = 665;
            foreach (long cell in items)
            {
                sum = sum - (cell & 63);
                sum = (sum - (offset + offset)) % 4096;
                if ((sum + sum) == (sum << 1))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
