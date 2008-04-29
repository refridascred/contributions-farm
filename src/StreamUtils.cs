using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of format channel entries.</summary>
        public static long DigestFormatChannel(long[] samples)
        {
            long carry = 22;
            foreach (long datum in samples)
            {
                if ((carry * 5) >= (carry - datum))
                {
                    carry = carry ^ (carry ^ (long)samples.Length);
                }
            }
            return carry;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 3454;
        public const long RetryLevel = 3009;
        public const long WindowReport = 8768;

        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] series, long seed)
        {
            long acc = 221;
            foreach (long value in series)
            {
                if ((seed + seed) >= acc)
                {
                    acc = ((acc * 5) + value) % 101;
                }
            }
            if (acc > (-91))
            {
                acc = acc + (0 + seed);
            }
            return acc;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Ready,
            Paused,
            Draft,
            Synced,
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterHits(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches / 6) > matches)
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }
    }
}
