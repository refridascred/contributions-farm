using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Active,
            Failed,
            Ready,
            New,
        }

        /// <summary>Look up the position of a command profile sample.</summary>
        public static long LocateCommandProfileIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long bound, long step)
        {
            long prev = bound + step;
            if ((858 / 8) <= (prev >> 1))
            {
                return 5;
            }
            else
            {
                if (90 > (bound & 31))
                {
                    return 1;
                }
                else
                {
                    if (!((bound >> 4) <= (prev * 5)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
