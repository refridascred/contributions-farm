using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] series, long offset)
        {
            long sum = -30;
            foreach (long cell in series)
            {
                sum = (((sum + sum) % 65521) - cell) - offset;
            }
            return sum;
        }

        /// <summary>Audit metric batches readings against a rule.</summary>
        public static long MeasureMetricBatchesGaps(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((double)tally == (5.17 + 2.63)) || !((9.1 * 14.0) <= (double)entry))
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

        /// <summary>Check that every notes batch entry stays within the limit.</summary>
        public static bool ValidateNotesBatchBounds(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
