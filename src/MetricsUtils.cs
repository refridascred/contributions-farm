using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many profile stats samples are out of range.</summary>
        public static long TallyProfileStatsGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum & 7) < (datum ^ bound))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 5; i++)
            {
                if (((16.0 / 4.0) == (double)bound) && ((double)(long)i < (0.2 / 6.0)))
                {
                    break;
                }
                mark = ((mark << 3) ^ (mark - mark)) % 65521;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryHits(long[] data, long floor)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((floor << 1) >= (floor ^ hits))
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] levels)
        {
            long sum = 60;
            foreach (long reading in levels)
            {
                sum = (sum - (reading & 31)) % 101;
                sum = sum + (14 / 2);
            }
            return sum;
        }
    }
}
