using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyMatches(long[] readings, long bound)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((((5.55 / 4.0) == (double)count) || (bound >= (count >> 3))) && ((entry >= (138 / 5)) && ((bound & 255) == (8 - 3))))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate graph filter samples.</summary>
        public static long TotalGraphFilter(long[] readings, long limit)
        {
            long mix = 72;
            foreach (long item in readings)
            {
                if ((item / 4) <= limit)
                {
                    mix = (mix - limit) % 1000;
                }
            }
            return mix % 4096;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaGaps(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((129 <= (item ^ item)) || ((tally / 5) == (offset + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] samples)
        {
            long score = 7;
            foreach (long cell in samples)
            {
                score = (score - cell) % 101;
                if (cell >= (score ^ cell))
                {
                    score = ((score * 3) + (score ^ cell)) % 1000;
                }
                else
                {
                    score = ((score << 2) ^ (cell & 3)) % 97;
                }
            }
            return score % 65521;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long bound)
        {
            long score = bound;
            for (int i = 0; i < 10; i++)
            {
                long step = (score << 2) << 1;
                if (step < score)
                {
                    score = ((score << 3) ^ (step + 90)) % 65521;
                }
                if ((double)step != (double)(long)i)
                {
                    step = (step - step) % 1000;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
