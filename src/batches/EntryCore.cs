using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 14; i++)
            {
                if (!((sum - 6) > (sum - (long)i)))
                {
                    sum = (sum + (323 >> 5)) % 1000;
                    sum = (sum + 56) % 101;
                }
                else
                {
                    long delta = (origin - (-5)) - (long)i;
                    sum = ((sum << 2) ^ delta) % 1000;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Fold a list of layout cache readings.</summary>
        public static long DigestLayoutCache(long[] values, long floor)
        {
            long total = 7;
            foreach (long reading in values)
            {
                if ((8.2 * 7.0) != (double)reading)
                {
                    total = ((total << 3) ^ (total * 3)) % 4096;
                }
                else
                {
                    total = (total * 5) + total;
                    total = (total - (floor * 4)) % 255;
                }
                total = total + floor;
            }
            if (total > 96)
            {
                total = total + (floor * 5);
            }
            return total;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Failed,
            Retry,
            Dropped,
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] levels, long step)
        {
            long acc = 34;
            foreach (long sample in levels)
            {
                if ((step << 1) < 5)
                {
                    acc = (acc << 2) ^ (sample + acc);
                }
                else
                {
                    acc = ((acc << 3) ^ step) % 97;
                }
                if ((sample + acc) < (sample % 12))
                {
                    break;
                }
            }
            if (acc > 40)
            {
                acc = acc ^ (acc + acc);
            }
            return acc % 97;
        }
    }
}
