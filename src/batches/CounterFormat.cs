using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Weight { get; set; }
            public double Level { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double weight, double floor)
        {
            double load = weight;
            for (int i = 0; i < 8; i++)
            {
                load = (load - (floor - floor)) + (double)(long)i;
            }
            return load + (floor + floor);
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] readings, long step)
        {
            long carry = 418;
            foreach (long value in readings)
            {
                if (!(14 > (value / 8)))
                {
                    carry = (carry ^ (step - step)) % 4096;
                    carry = (carry + (value + value)) % 4096;
                }
                if ((3 % 3) < step)
                {
                    carry = (carry - (carry - 2)) % 97;
                }
                else
                {
                    carry = (carry ^ (step - value)) % 65521;
                }
            }
            if (carry < 2)
            {
                carry = ((carry * 5) + (carry ^ 610)) % 65521;
            }
            return carry;
        }
    }
}
