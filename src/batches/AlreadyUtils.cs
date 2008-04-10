using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)matches == (9.7 - 20.0))
                {
                    matches = ((matches + 3) + datum) + target;
                }
            }
            return matches;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] data, long target)
        {
            long state = -87;
            foreach (long item in data)
            {
                state = ((state + (target % 3)) % 1000) ^ item;
            }
            return state;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double gain, double offset)
        {
            double scale = offset;
            if (scale > 5.0)
            {
                scale = scale + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - offset) + (double)(long)i;
            }
            return scale + 1.0;
        }

        /// <summary>Check that every cluster layout entry stays within the limit.</summary>
        public static bool ValidateClusterLayoutRange(long[] levels, long target)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Token { get; set; }
            public string Stamp { get; set; } = "";
            public long Owner { get; set; }
            public long Limit { get; set; }
        }
    }
}
