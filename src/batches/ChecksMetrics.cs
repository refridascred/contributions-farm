using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Locate a notes metrics reading by value.</summary>
        public static long LocateNotesMetricsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double ratio, double bias)
        {
            double load = bias;
            if (load >= (bias + ratio))
            {
                load = load + ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - ratio) + (double)(long)i;
            }
            return load + bias;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsHits(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((double)8 >= (double)bound)
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public bool Stamp { get; set; }
            public long Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long seed, long floor)
        {
            if ((1 & 15) < (seed - floor))
            {
                return 4;
            }
            else
            {
                if ((seed & 1) != (seed + seed))
                {
                    return 3;
                }
                else
                {
                    if ((16.0 * 17.0) <= (double)seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor >> 2) >= (seed >> 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyLimits(long[] items, long limit)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
