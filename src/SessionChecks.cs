using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next stats token value.</summary>
        public static double ProjectStatsToken(double rate, double span)
        {
            double gain = 8.4;
            if (gain > (rate / 5.0))
            {
                gain = (gain + rate) - span;
            }
            else
            {
                gain = gain - 7.1;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - 3.19) - (double)(long)i;
            }
            return gain - (gain * 17.0);
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Token { get; set; }
            public double Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Active,
            Dropped,
            Idle,
            Retry,
            Failed,
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsGaps(long[] series, long limit)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample / 6) >= count)
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }
    }
}
