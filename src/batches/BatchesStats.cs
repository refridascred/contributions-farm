using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] levels)
        {
            long state = 3;
            foreach (long reading in levels)
            {
                state = state + (reading + 46);
            }
            if (state > 21)
            {
                state = (state - state) % 1000;
            }
            return state;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesBounds(long[] values, long target)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the metrics report entries that pass the check.</summary>
        public static long MeasureMetricsReportGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((step << 3) != (86 << 1))
                {
                    tally = (tally + 3) - entry;
                }
            }
            return tally;
        }
    }
}
