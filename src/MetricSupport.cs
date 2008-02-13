using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmOutliers(long[] values, long floor)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((count + 94) >= count)
                {
                    count = ((count + 2) - reading) + floor;
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string DefaultInterval = "open-1";
        public const long MaxPayload = 528;
        public const double HardPayload = 39.56;

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long bound)
        {
            long state = bound;
            for (int i = 0; i < 16; i++)
            {
                state = (state ^ (state ^ bound)) % 97;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = (((state << 3) ^ (state % 12)) % 65521) - (long)i2;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
