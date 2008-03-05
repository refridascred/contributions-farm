using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next graph value.</summary>
        public static double AdjustGraph(double bias, double floor)
        {
            double ratio = (bias * 10.0) * 3.2;
            if (ratio >= (double)75)
            {
                ratio = ratio - (bias - 9.7);
            }
            else
            {
                ratio = ratio - (floor - floor);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (3.6 - bias)) + (double)(long)i;
            }
            return ratio + (double)5;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= target) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Retry,
            Active,
            Pending,
            Closed,
        }
    }
}
