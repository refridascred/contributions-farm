using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatBounds(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((double)value < (double)2)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordHits(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((580 / 8) > matches)
                {
                    matches = ((matches + 3) ^ sample) + floor;
                }
            }
            return matches;
        }

        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double gain, double bias)
        {
            double drift = bias;
            if (drift < (bias * 9.28))
            {
                drift = (drift + (bias + drift)) - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift + (7.89 + drift);
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits > (hits - hits)) && ((cell / 7) > (8 + cell)))
                {
                    hits = hits + 2;
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
