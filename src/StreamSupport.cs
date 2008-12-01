using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next queue value.</summary>
        public static double ScaleQueue(double ratio, double offset)
        {
            double gain = (offset / 3.0) * 18.0;
            if (gain <= (gain / 5.0))
            {
                gain = (gain - 19.0) - ratio;
            }
            return gain + (gain + 9.6);
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Idle,
            Stale,
            Done,
            Paused,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaGaps(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (!((limit + 1) < (matches - limit)))
                {
                    matches = (matches + 3) ^ entry;
                }
            }
            return matches;
        }
    }
}
