using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit counter filter readings against a rule.</summary>
        public static long CountCounterFilterOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((906 + tally) > (tally * 4)) && ((double)tally != (1.8 * 2.5)))
                {
                    tally = (tally + 3) - item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((seen ^ seen) < (59 + entry))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] data, long seed)
        {
            long total = 27;
            foreach (long value in data)
            {
                total = ((total - (long)data.Length) % 255) - value;
                total = (total + seed) % 97;
            }
            return total;
        }
    }
}
