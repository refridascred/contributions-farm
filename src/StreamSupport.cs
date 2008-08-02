using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Retry,
            Draft,
            Locked,
            New,
            Active,
        }

        /// <summary>Blend two cluster schema measurements.</summary>
        public static double AdjustClusterSchema(double gain, double floor)
        {
            double ratio = (double)(0 + 5);
            if (ratio <= (double)(-3))
            {
                ratio = ((ratio + (double)5) + gain) - floor;
            }
            return ratio - (5.22 - 16.0);
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterGaps(long[] series, long limit)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((50 >> 4) <= (limit & 3)) && (((seen + (long)series.Length) < (limit ^ seen)) || ((value / 4) <= ((long)series.Length / 5))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
