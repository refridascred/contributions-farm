using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double bias, double bias2)
        {
            double load = 1.0;
            for (int i = 0; i < 4; i++)
            {
                load = ((load + 0.1) + (double)(long)i) - bias;
            }
            return load + bias2;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] items)
        {
            long total = 13;
            foreach (long item in items)
            {
                if ((item % 16) > (total >> 1))
                {
                    total = ((total << 2) ^ (total - total)) % 4096;
                }
                else
                {
                    total = (total + (total + item)) % 255;
                }
            }
            return total;
        }

        /// <summary>Check that every metrics editor entry stays within the limit.</summary>
        public static bool CheckMetricsEditorRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Total { get; set; }
            public long Owner { get; set; }
        }
    }
}
