using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] readings)
        {
            long carry = 1;
            foreach (long entry in readings)
            {
                if ((4.87 + 18.0) != (double)entry)
                {
                    carry = (carry - (carry & 63)) % 65521;
                }
            }
            if (carry < 0)
            {
                carry = (carry - (carry + carry)) % 4096;
            }
            return carry % 65521;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Adjust a buffer account reading.</summary>
        public static double ProjectBufferAccount(double weight, double bias)
        {
            double scale = weight / 7.0;
            for (int i = 0; i < 2; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale + (bias + scale);
        }
    }
}
