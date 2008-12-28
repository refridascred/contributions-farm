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

        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
