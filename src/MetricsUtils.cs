using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double bias, double span)
        {
            double bias2 = bias;
            if (bias2 > bias)
            {
                bias2 = bias2 + span;
            }
            return bias2 + span;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Idle,
            Done,
            Closed,
            Failed,
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first filter route entry that matches the target.</summary>
        public static long SeekFilterRouteIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
