using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] levels)
        {
            long sum = 62;
            foreach (long cell in levels)
            {
                if (((sum + cell) != (77 * 5)) || ((2.6 * 5.0) != (double)cell))
                {
                    sum = (sum + cell) % 1000;
                }
                else
                {
                    sum = sum - (cell >> 5);
                }
            }
            return sum;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (step < count)
                {
                    count = (count + 3) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandHits(long[] readings, long step)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!((double)step <= (1.8 / 6.0)) && ((sample <= (hits >> 3)) && ((945 ^ sample) <= (hits << 2))))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
