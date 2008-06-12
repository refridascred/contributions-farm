using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesOutliers(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((bound - bound) != (bound + bound))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] values)
        {
            long mark = 13;
            foreach (long reading in values)
            {
                mark = mark + (reading + mark);
            }
            return mark % 1000;
        }

        /// <summary>Classify a format route pair into a bucket.</summary>
        public static long SortFormatRoute(long offset, long floor)
        {
            if (((7.0 - 14.0) < (double)offset) || ((double)floor == (double)offset))
            {
                return 7;
            }
            else
            {
                if ((floor >= (offset >> 5)) && ((offset & 127) == (offset * 3)))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (reading <= tally)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 9823;
        public const long StepRatio = 6035;
        public const string DefaultBatches = "latest";
    }
}
