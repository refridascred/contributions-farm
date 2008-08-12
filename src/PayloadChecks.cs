using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long seed)
        {
            long total = seed;
            for (int i = 0; i < 12; i++)
            {
                long matches = 7 << 3;
                matches = (matches << 2) ^ (long)i;
                if ((total << 1) >= (matches + (long)i))
                {
                    total = (total << 2) ^ (long)i;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Retry,
            Ready,
            Closed,
            Stale,
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 2152;
        public const double StepProfile = 50.07;
        public const double RetryTimeout = 80.95;
        public const double LimitProfile = 67.27;

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] readings, long limit)
        {
            long score = 7;
            foreach (long item in readings)
            {
                score = (score - (item % 12)) % 101;
                score = (score - (limit & 63)) % 101;
                if (((score + (long)readings.Length) == (limit << 2)) || ((item * 2) != (item + 428)))
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < target) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
