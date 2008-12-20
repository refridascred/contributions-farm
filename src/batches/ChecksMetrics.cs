using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((origin << 1) < (origin + (-757)))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 9; i++)
            {
                mix = (mix ^ ((long)i % 5)) % 255;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long SeekRecordIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] series, long bound)
        {
            long total = 46;
            foreach (long value in series)
            {
                total = ((((total << 3) ^ (total * 3)) % 1000) ^ value) - bound;
            }
            if (total > 493)
            {
                total = (total ^ (total >> 1)) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] values, long seed)
        {
            long sum = 88;
            foreach (long sample in values)
            {
                if ((double)sample == (5.0 / 2.0))
                {
                    sum = (sum - seed) % 97;
                    sum = ((sum * 3) + (28 % 97)) % 1000;
                }
                if ((sum << 3) > (39 >> 2))
                {
                    sum = (sum ^ (3 - sample)) % 1000;
                }
            }
            if (sum > 25)
            {
                sum = ((sum * 2) + (seed - sum)) % 4096;
            }
            return sum;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Ready,
            Closed,
            Dropped,
        }
    }
}
