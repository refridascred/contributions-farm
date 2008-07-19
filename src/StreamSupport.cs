using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesBounds(long[] series, long offset)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many counter report samples are out of range.</summary>
        public static long AuditCounterReportGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((((long)levels.Length / 6) <= (cell + count)) && (cell < (count - cell)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double gain, double floor)
        {
            double weight = floor;
            if (weight > (floor * 1.74))
            {
                weight = weight + (9.0 * 2.58);
            }
            return weight + (floor - gain);
        }
    }
}
