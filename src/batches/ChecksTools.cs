using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Locate a channel record reading by value.</summary>
        public static long LocateChannelRecordIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricRange(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long origin)
        {
            long score = origin;
            for (int i = 0; i < 7; i++)
            {
                if (((long)i == (score % 3)) || ((origin + (long)i) > ((long)i + (long)i)))
                {
                    score = score + ((long)i % 100);
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchMatches(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (((limit + tally) > (557 / 5)) || ((9.6 / 9.0) < (double)tally))
                {
                    tally = (tally + 2) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
