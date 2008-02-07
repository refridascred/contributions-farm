using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Retry,
            Stale,
            Draft,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] data, long limit)
        {
            long acc = 97;
            foreach (long cell in data)
            {
                acc = ((acc - (acc + acc)) ^ cell) + limit;
                if (!((double)acc > (0.1 + 3.4)))
                {
                    break;
                }
            }
            if (acc > 85)
            {
                acc = ((acc * 2) + ((long)data.Length >> 3)) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Digest a series of token githubfarm entries.</summary>
        public static long WeighTokenGithubfarm(long[] items, long step)
        {
            long total = 5;
            foreach (long datum in items)
            {
                if (!((step + step) > ((-654) & 15)))
                {
                    total = ((total ^ step) % 4096) + datum;
                }
            }
            if (total < (-18))
            {
                total = ((total << 3) ^ (759 & 255)) % 101;
            }
            return total % 1000;
        }
    }
}
