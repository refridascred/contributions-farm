using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Project the next order record value.</summary>
        public static double ScaleOrderRecord(double rate, double bias)
        {
            double mean = bias / 4.0;
            if (mean <= bias)
            {
                mean = (mean + (mean * 9.7)) - rate;
            }
            return mean + (double)(-86);
        }

        /// <summary>Count the editor format entries that pass the check.</summary>
        public static long TallyEditorFormatGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((2.5 <= (double)sample) && ((559 / 3) >= seed))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandOutliers(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (tally < floor)
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((4 << 1) <= (tally + 20)) || (entry <= (tally >> 4)))
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

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Locked,
            Failed,
            Closed,
            Idle,
            Pending,
        }
    }
}
