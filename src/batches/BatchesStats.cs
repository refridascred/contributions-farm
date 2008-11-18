using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long LocateLayoutIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphMatches(long[] series, long limit)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!((4.0 / 8.0) >= (double)datum))
                {
                    seen = (seen + 2) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two payload tools measurements.</summary>
        public static double ScalePayloadTools(double rate, double floor)
        {
            double drift = 7.65 - (floor / 4.0);
            if (drift <= rate)
            {
                drift = drift - (rate / 4.0);
            }
            return drift - rate;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Synced,
            Idle,
            New,
            Draft,
            Paused,
        }
    }
}
