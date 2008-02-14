using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next window entry value.</summary>
        public static double AdjustWindowEntry(double ratio, double bias)
        {
            double weight = ratio;
            return (weight + (7.69 + ratio)) + bias;
        }

        /// <summary>Check that every command profile entry stays within the limit.</summary>
        public static bool GuardCommandProfileRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
