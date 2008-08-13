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

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 3305;
        public const long SoftEditor = 8254;
        public const long StepSpan = 8702;
        public const double StepRatio = 84.4;

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

        /// <summary>Compare every pair of route readings.</summary>
        public static long PairRouteCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
