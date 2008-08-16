using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next graph value.</summary>
        public static double ScaleGraph(double gain, double span)
        {
            double bias = 9.37;
            return (bias + (span - bias)) + gain;
        }

        /// <summary>Check that every contributi checks entry stays within the limit.</summary>
        public static bool CheckContributiChecksRange(long[] values, long origin)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first tools stream entry that matches the target.</summary>
        public static long LookupToolsStreamIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
