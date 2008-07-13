using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Ready,
            Synced,
            Closed,
            Dropped,
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public double Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double gain, double floor)
        {
            double scale = gain;
            if (scale >= (floor - scale))
            {
                scale = scale - (floor - 9.5);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (2.3 - gain)) + (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowLimits(long[] series, long step)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
