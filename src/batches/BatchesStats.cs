using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long floor)
        {
            long score = floor;
            for (int i = 0; i < 24; i++)
            {
                if (((long)i <= score) && (floor < ((long)i - score)))
                {
                    score = (score << 3) ^ 90;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((9.0 * 3.0) != (double)tally)
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiMatches(long[] data, long floor)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!(((sample + sample) == (sample - floor)) || ((floor ^ seen) > floor)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
