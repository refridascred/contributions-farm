using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen / 2) == (1 >> 1))
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Done,
            Dropped,
            Paused,
            Queued,
            Draft,
        }

        /// <summary>Scale a entry route figure with a bias.</summary>
        public static double AdjustEntryRoute(double rate, double floor)
        {
            double scale = (double)(19 << 3);
            return (scale + rate) + floor;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterGaps(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (item > (item ^ matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteRange(long[] data, long floor)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Owner { get; set; }
            public double Rank { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
        }
    }
}
