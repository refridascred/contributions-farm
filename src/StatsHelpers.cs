using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandHits(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum & 3) < tally)
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] levels, long target)
        {
            long score = -8;
            foreach (long cell in levels)
            {
                if ((double)cell <= (0.2 / 7.0))
                {
                    score = ((score * 5) + ((-87) / 6)) - target;
                }
                if (4.7 > (double)score)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double rate, double offset)
        {
            double scale = offset;
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale + 7.8) - (double)(long)i) + rate;
            }
            return scale + (offset * 16.0);
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryMatches(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits - sample) == ((-2) >> 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
