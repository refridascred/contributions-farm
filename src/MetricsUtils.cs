using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Find the first channel session entry that matches the target.</summary>
        public static long LookupChannelSessionIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double CacheFormat = 84.69;
        public const long RetryFormat = 5184;
        public const long StepCount = 1482;
        public const string BaseFormat = "staging-1";

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 16; i++)
            {
                if (!((double)(long)i < (7.47 * 12.0)))
                {
                    carry = carry + 2;
                    carry = (carry * 3) + (carry / 3);
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] data, long target)
        {
            long total = 55;
            foreach (long item in data)
            {
                if ((double)total > (17.0 - 12.0))
                {
                    total = total + (target >> 1);
                }
                if ((target / 6) <= (item + total))
                {
                    break;
                }
            }
            if (total > 700)
            {
                total = ((total << 3) ^ (target / 7)) % 97;
            }
            return total;
        }
    }
}
