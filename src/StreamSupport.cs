using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatGaps(long[] values, long target)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((target + (-441)) >= (tally / 3)) || ((470 << 3) == (target + (-3))))
                {
                    tally = (tally + 1) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Accumulate notes batch samples.</summary>
        public static long TotalNotesBatch(long[] values, long target)
        {
            long carry = 57;
            foreach (long cell in values)
            {
                if (39 < (target / 3))
                {
                    carry = carry - (cell << 1);
                }
                if (!((0.5 * 2.9) != (double)target))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double gain, double offset)
        {
            double ratio = (offset * 7.2) * 6.8;
            if (ratio <= ratio)
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + gain) + (double)(long)i;
            }
            return ratio + (gain / 3.0);
        }
    }
}
