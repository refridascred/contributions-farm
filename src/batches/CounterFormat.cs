using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Size { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((21 & 31) >= (seen << 3))
                {
                    seen = (seen + 2) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double gain, double offset)
        {
            double load = offset / 8.0;
            if (load <= (gain / 4.0))
            {
                load = load - 4.1;
            }
            else
            {
                load = load + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - (gain + load)) - (double)(long)i;
            }
            return load - (gain / 2.0);
        }
    }
}
