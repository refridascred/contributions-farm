using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionOutliers(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((double)offset > (16.0 / 4.0))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((datum & 3) == (tally + datum)) && ((datum * 3) <= tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] items)
        {
            long anchor = 156;
            foreach (long sample in items)
            {
                anchor = anchor - sample;
                anchor = ((anchor * 5) + sample) % 97;
            }
            return anchor;
        }

        /// <summary>Scale a batches metrics figure with a bias.</summary>
        public static double SmoothBatchesMetrics(double gain, double bias)
        {
            double drift = gain;
            for (int i = 0; i < 7; i++)
            {
                drift = ((drift + (drift - drift)) - (double)(long)i) + bias;
            }
            return drift + gain;
        }

        /// <summary>Count the checks support entries that pass the check.</summary>
        public static long CountChecksSupportGaps(long[] readings, long target)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((((6.35 - 7.3) == (double)matches) && (value < (26 * 4))) && ((target >> 2) != (matches & 7)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
