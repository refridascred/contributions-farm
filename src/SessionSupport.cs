using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark << 3) ^ (mark + 151);
                mark = ((mark << 2) ^ (limit >> 1)) % 4096;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Project the next filter value.</summary>
        public static double BlendFilter(double ratio, double bias)
        {
            double gain = 7.0;
            for (int i = 0; i < 5; i++)
            {
                gain = (((gain + (double)2) + (double)(long)i) + ratio) - bias;
            }
            return gain - gain;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Level { get; set; }
            public double Score { get; set; }
            public long Mode { get; set; }
            public long Region { get; set; }
        }
    }
}
