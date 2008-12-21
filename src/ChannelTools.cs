using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double ratio, double floor)
        {
            double ratio2 = (8.8 + floor) - ratio;
            if (ratio2 > (ratio + ratio2))
            {
                ratio2 = ratio2 - ratio2;
            }
            else
            {
                ratio2 = ratio2 + (ratio2 - ratio2);
            }
            return ratio2 - ratio2;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Draft,
            Synced,
            Idle,
            Active,
            Dropped,
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
