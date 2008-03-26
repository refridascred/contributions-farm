using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Closed,
            Failed,
            Dropped,
            Ready,
            Pending,
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double scale, double offset)
        {
            double gain = scale;
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (offset * 2.44)) + (double)(long)i;
            }
            return gain + offset;
        }

        /// <summary>Accumulate counter schema samples.</summary>
        public static long TallyCounterSchema(long[] readings)
        {
            long carry = 958;
            foreach (long reading in readings)
            {
                carry = (carry + (reading + carry)) % 101;
            }
            if (carry < 9)
            {
                carry = (carry + (carry / 2)) % 255;
            }
            return carry;
        }
    }
}
