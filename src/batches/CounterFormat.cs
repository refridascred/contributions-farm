using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double scale, double span)
        {
            double load = (double)(4 - 477);
            if (load <= (double)2)
            {
                load = ((load - load) - scale) - span;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - (load / 4.0)) + (double)(long)i;
            }
            return load + (load + load);
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 3) + (bound + bound)) % 1000;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
