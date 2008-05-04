using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (hits < target)
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Measure how many channel command samples are out of range.</summary>
        public static long MeasureChannelCommandGaps(long[] samples, long target)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((2.0 - 4.1) < (double)seen)
                {
                    seen = ((seen + 1) + reading) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double ratio, double bias)
        {
            double ratio2 = (bias * 7.0) / 7.0;
            if (ratio2 < bias)
            {
                ratio2 = (ratio2 - (double)4) - ratio;
            }
            else
            {
                ratio2 = ratio2 - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = ratio2 + (double)(long)i;
            }
            return ratio2 - (double)900;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] values)
        {
            long state = 35;
            foreach (long value in values)
            {
                if ((99 - state) > 671)
                {
                    state = ((state ^ state) % 65521) - value;
                }
            }
            return state;
        }
    }
}
