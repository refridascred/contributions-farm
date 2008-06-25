using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next entry cluster value.</summary>
        public static double AdjustEntryCluster(double scale, double floor)
        {
            double rate = (floor * 3.77) - 4.8;
            return (rate + (floor * 3.02)) + scale;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public string Token { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryGaps(long[] items, long seed)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((matches - matches) > (item + seed)) && ((762 % 100) != (seed >> 2)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
