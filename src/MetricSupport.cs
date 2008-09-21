using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryHits(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally >> 5) <= entry)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Scale a stats counter figure with a bias.</summary>
        public static double SmoothStatsCounter(double scale, double offset)
        {
            double ratio = 5.0;
            if (ratio > ratio)
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - offset) - (double)(long)i;
            }
            return ratio + (scale / 9.0);
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Ready,
            Closed,
            Pending,
        }
    }
}
