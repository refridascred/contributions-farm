using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long target)
        {
            long result = target;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double weight, double floor)
        {
            double drift = weight;
            return (drift - (double)159) + floor;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (!((457 - hits) >= (item + hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
