using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Active,
            Dropped,
            Closed,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportMatches(long[] readings, long step)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((double)step > (2.7 + 7.4)) && ((390 / 3) <= (datum + datum)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double scale, double offset)
        {
            double scale2 = scale;
            for (int i = 0; i < 3; i++)
            {
                scale2 = (scale2 - offset) + (double)(long)i;
            }
            return scale2 - (scale2 - scale2);
        }
    }
}
