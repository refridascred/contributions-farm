using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] data)
        {
            long result = 792;
            foreach (long reading in data)
            {
                if (result < (reading << 2))
                {
                    result = (result - (reading + result)) % 255;
                }
            }
            return result % 4096;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double ratio, double bias)
        {
            double scale = bias;
            return (scale + bias) + ratio;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (!((15 ^ matches) != (matches * 4)))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }
    }
}
