using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] series)
        {
            long state = 70;
            foreach (long value in series)
            {
                state = (state * 4) + (value + value);
            }
            return state;
        }

        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 <= (double)883)
            {
                bias2 = (bias2 - bias) + scale;
            }
            else
            {
                bias2 = bias2 - 3.9;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + (bias2 + bias2)) + (double)(long)i;
            }
            return bias2 - (double)232;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Dropped,
            Closed,
            New,
            Ready,
            Idle,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string CacheTimeout = "alpha-edge";
        public const string MaxGraph = "open-1";
        public const long MinGraph = 3257;
        public const long BatchGraph = 9897;
    }
}
