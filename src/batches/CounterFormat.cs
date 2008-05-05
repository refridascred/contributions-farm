using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ProjectEntry(double ratio, double bias)
        {
            double load = bias + ratio;
            return load + (ratio * 6.4);
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string StepQueue = "primary-1";
        public const long MaxLevel = 9760;
        public const long WindowQueue = 3046;
        public const string RetrySize = "standard-v2";
    }
}
