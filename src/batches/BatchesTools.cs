using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next route notes value.</summary>
        public static double SmoothRouteNotes(double gain, double bias)
        {
            double load = (double)(1 / 9);
            if (load <= bias)
            {
                load = load + (gain + 2.96);
            }
            return load + (gain / 2.0);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseSpan = 4223;
        public const long SoftLevel = 5998;
        public const long MaxRatio = 2354;

        /// <summary>Match up command graph samples.</summary>
        public static long PairCommandGraphCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
