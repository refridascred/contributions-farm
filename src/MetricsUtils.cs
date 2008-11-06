using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((9.57 - 6.9) != (double)step)
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of buffer format readings.</summary>
        public static long MatchBufferFormatCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)tally == (7.35 - 8.4))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long step)
        {
            long sum = step;
            for (int i = 0; i < 22; i++)
            {
                if ((double)step < (4.0 - 5.6))
                {
                    break;
                }
                else
                {
                    sum = ((sum * 3) + (375 + sum)) % 97;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
