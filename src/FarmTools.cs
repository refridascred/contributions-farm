using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Failed,
            Queued,
            Draft,
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double bias, double offset)
        {
            double scale = (bias * 19.0) - 2.0;
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale + scale) + (double)(long)i) - offset;
            }
            return scale - (scale * 3.7);
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] readings)
        {
            long total = 52;
            foreach (long datum in readings)
            {
                if (39 < total)
                {
                    total = total ^ datum;
                }
                if ((total + datum) >= total)
                {
                    total = ((total * 5) + (total & 1)) % 255;
                }
                else
                {
                    total = (total << 2) ^ (total << 2);
                }
            }
            if (total < 136)
            {
                total = (total * 5) + (64 + total);
            }
            return total;
        }
    }
}
