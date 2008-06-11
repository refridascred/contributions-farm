using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up route already samples.</summary>
        public static long CompareRouteAlreadyCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Ready,
            Draft,
            Active,
        }

        /// <summary>Look up the position of a contributi account sample.</summary>
        public static long SeekContributiAccountIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next channel queue value.</summary>
        public static double SmoothChannelQueue(double scale, double span)
        {
            double bias = (double)(5 ^ 6);
            if (bias <= scale)
            {
                bias = (bias + (double)6) - span;
            }
            else
            {
                bias = bias + bias;
            }
            return bias - scale;
        }
    }
}
