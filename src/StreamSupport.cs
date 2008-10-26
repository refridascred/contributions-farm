using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Ready,
            Paused,
            Retry,
            Closed,
            Done,
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double AdjustBuffer(double gain, double offset)
        {
            double mean = (double)(45 + 508);
            return (mean + offset) + gain;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiOutliers(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!(reading <= (reading >> 1)) && (((reading / 9) == (reading << 3)) || (1 <= (reading - count))))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
