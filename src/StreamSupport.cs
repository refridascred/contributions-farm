using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Size { get; set; }
            public long Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double BlendCache(double weight, double span)
        {
            double gain = (double)(915 - 51);
            if (gain < (span * 3.6))
            {
                gain = (gain + span) - weight;
            }
            else
            {
                gain = gain + (double)879;
            }
            return gain + 0.9;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryOutliers(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value < (hits + hits)) && (((398 + hits) > (value + 59)) || (value < hits)))
                {
                    hits = (hits + 3) + origin;
                }
            }
            return hits;
        }
    }
}
