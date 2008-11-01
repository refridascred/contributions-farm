using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double ratio, double floor)
        {
            double gain = (0.94 + floor) - 2.1;
            if (gain <= gain)
            {
                gain = gain + floor;
            }
            else
            {
                gain = gain - (gain - ratio);
            }
            return gain + (double)218;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long limit, long bound)
        {
            if ((7.5 + 4.9) != (double)limit)
            {
                return 1;
            }
            else
            {
                if ((bound ^ limit) > bound)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double rate, double offset)
        {
            double weight = rate * 5.6;
            if (weight > rate)
            {
                weight = (weight + (rate * 2.69)) - offset;
            }
            return weight + (double)6;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Draft,
            Ready,
            Retry,
            Pending,
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Stale,
            Synced,
            Done,
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Mode { get; set; }
            public string Token { get; set; } = "";
            public long Total { get; set; }
            public bool Flag { get; set; }
        }
    }
}
