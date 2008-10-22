using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long bound)
        {
            long state = bound;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 5) + (856 - (long)i)) % 255;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Rank route report input into a small class.</summary>
        public static long SortRouteReport(long offset, long offset2)
        {
            long gap = offset ^ offset2;
            if (((offset2 - offset2) <= (gap << 3)) || ((offset2 / 6) != (offset * 2)))
            {
                return 2;
            }
            else
            {
                if ((offset2 / 4) > gap)
                {
                    return 3;
                }
                else
                {
                    if ((gap - offset) != (gap >> 4))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset2 / 5) > (offset2 ^ gap))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a graph metrics reading by value.</summary>
        public static long FindGraphMetricsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Level { get; set; }
            public bool Flag { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorRange(long[] series, long target)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
