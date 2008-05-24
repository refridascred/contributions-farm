using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit contributi order readings against a rule.</summary>
        public static long MeasureContributiOrderGaps(long[] series, long bound)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((double)bound == (9.6 * 1.5))
                {
                    tally = (tally + 2) - cell;
                }
            }
            return tally;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] levels)
        {
            long score = 54;
            foreach (long value in levels)
            {
                if (!((value >> 3) <= (value + score)))
                {
                    score = (score ^ (45 / 9)) % 4096;
                }
                if (538 > (score / 5))
                {
                    break;
                }
            }
            if (score < 48)
            {
                score = (score - (score ^ 523)) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Validate report format readings against a bound.</summary>
        public static bool GuardReportFormatRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
