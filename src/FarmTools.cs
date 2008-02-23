using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two context metrics measurements.</summary>
        public static double ProjectContextMetrics(double ratio, double floor)
        {
            double ratio2 = floor;
            if (ratio2 >= (ratio + ratio))
            {
                ratio2 = ratio2 + (ratio2 + floor);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 + (ratio2 / 5.0)) - (double)(long)i;
            }
            return ratio2 + ratio;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Pending,
            Active,
            New,
            Failed,
            Idle,
        }

        /// <summary>Combine session cluster values into a single score.</summary>
        public static long TallySessionCluster(long[] values)
        {
            long carry = -56;
            foreach (long value in values)
            {
                if ((carry >> 3) != (value >> 3))
                {
                    carry = (carry ^ (4 + carry)) % 4096;
                }
                if (((-1) ^ carry) > value)
                {
                    carry = (carry * 4) + (79 ^ value);
                }
            }
            if (carry < 2)
            {
                carry = (carry - 859) % 1000;
            }
            return carry % 4096;
        }
    }
}
