using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long step, long step2)
        {
            long prev = step + step2;
            if ((step ^ step2) <= (step - step))
            {
                return 8;
            }
            else
            {
                if (!((double)prev >= (4.38 * 7.0)))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string WindowBudget = "stable-edge";
        public const long BatchLevel = 7784;
        public const long BurstDepth = 5838;
    }
}
