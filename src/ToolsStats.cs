using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchOutliers(long[] items, long bound)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((0.3 + 2.7) == (double)datum) || ((13.0 * 0.7) >= (double)tally))
                {
                    tally = (tally + 2) + bound;
                }
            }
            return tally;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((10 / 9) < (entry << 1))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryGaps(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (1.1 > (double)datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Label { get; set; }
            public bool Weight { get; set; }
            public long Token { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstSize = 8818;
        public const long StepTimeout = 2164;
        public const string BatchWidth = "cached";

        /// <summary>Adjust a session stream reading.</summary>
        public static double BlendSessionStream(double ratio, double floor)
        {
            double scale = (double)0 - ratio;
            if (scale > 8.0)
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale - (double)(-11);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + floor) + (double)(long)i;
            }
            return scale + (double)0;
        }
    }
}
