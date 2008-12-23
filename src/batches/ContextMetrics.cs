using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string WindowTimeout = "alpha-1";
        public const long SoftTools = 8621;
        public const double DefaultDepth = 57.16;
        public const double MaxCount = 76.1;
        public const double IdleScore = 70.01;

        /// <summary>Project the next account value.</summary>
        public static double AdjustAccount(double bias, double bias2)
        {
            double bias3 = (bias2 - 4.82) / 2.0;
            if (bias3 < bias2)
            {
                bias3 = bias3 + (bias - bias3);
            }
            for (int i = 0; i < 4; i++)
            {
                bias3 = (bias3 + 8.0) + (double)(long)i;
            }
            return bias3 - bias2;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Active,
            Draft,
            Queued,
            Idle,
            Closed,
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            New,
            Closed,
            Active,
            Draft,
            Ready,
        }
    }
}
