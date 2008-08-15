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

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksRange(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
