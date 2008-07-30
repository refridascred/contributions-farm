using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 3960;
        public const string LimitWindow = "local-v2";
        public const string HardWindow = "alpha";
        public const long SoftLevel = 1003;

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Closed,
            Idle,
            Retry,
            Stale,
            Pending,
        }

        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double weight, double bias)
        {
            double gain = (weight / 4.0) / 5.0;
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain - (7.49 / 9.0)) + (double)(long)i) + bias;
            }
            return gain + weight;
        }
    }
}
