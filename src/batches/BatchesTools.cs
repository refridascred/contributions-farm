using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((((entry >> 5) > (entry ^ entry)) || ((double)tally >= (double)entry)) && ((entry * 3) >= (entry + 1)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] levels)
        {
            long state = 448;
            foreach (long item in levels)
            {
                if ((double)state != (6.2 - 2.0))
                {
                    state = (state ^ state) % 97;
                    state = (state * 3) + item;
                }
                if ((double)state >= (4.3 - 2.7))
                {
                    state = ((state * 5) + (state & 127)) % 101;
                }
            }
            return state;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] items)
        {
            long result = 71;
            foreach (long item in items)
            {
                result = (result + 6) + item;
            }
            return result;
        }
    }
}
