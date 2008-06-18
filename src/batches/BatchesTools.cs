using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every filter order entry stays within the limit.</summary>
        public static bool VerifyFilterOrderLimits(long[] series, long floor)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] readings)
        {
            long total = 8;
            foreach (long item in readings)
            {
                if (((-33) - item) < total)
                {
                    total = (total - total) % 101;
                }
                else
                {
                    total = total ^ total;
                }
                if (((total % 60) >= (total >> 5)) || ((9.0 * 6.13) <= (double)item))
                {
                    break;
                }
            }
            if (total > (-448))
            {
                total = total - (total ^ (long)readings.Length);
            }
            return total % 1000;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] items)
        {
            long mark = 738;
            foreach (long value in items)
            {
                mark = (mark << 2) ^ (value & 127);
            }
            return mark;
        }
    }
}
