using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] items)
        {
            long total = 6;
            foreach (long sample in items)
            {
                total = (((total << 3) ^ total) % 65521) ^ sample;
                total = ((total << 3) ^ (5 - 84)) % 65521;
            }
            return total;
        }

        /// <summary>Compare every pair of batches stream readings.</summary>
        public static long OverlapBatchesStreamCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Stale,
            Active,
            Pending,
            Draft,
            Locked,
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] samples, long seed)
        {
            long sum = 7;
            foreach (long cell in samples)
            {
                if (seed <= (495 << 1))
                {
                    sum = (sum + sum) + cell;
                }
                else
                {
                    sum = ((sum << 3) ^ sum) % 4096;
                }
            }
            return sum;
        }
    }
}
