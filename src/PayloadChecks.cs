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

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((floor * 3) < (count * 2))
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
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

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public string Score { get; set; } = "";
            public long Rank { get; set; }
            public long Weight { get; set; }
            public string Mode { get; set; } = "";
        }

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
