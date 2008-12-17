using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferOutliers(long[] readings, long floor)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (9 >= (floor << 1))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Done,
            Active,
            Ready,
            New,
            Locked,
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ProjectAccount(double gain, double floor)
        {
            double ratio = floor;
            if (ratio >= gain)
            {
                ratio = ratio - gain;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + gain) - (double)(long)i;
            }
            return ratio - floor;
        }
    }
}
