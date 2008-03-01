using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 8354;
        public const string DefaultLevel = "alpha-1";
        public const double StepWidth = 46.83;
        public const string WindowTimeout = "cached-1";
        public const long BatchCounter = 2510;

        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double weight, double offset)
        {
            double ratio = offset;
            if (ratio < (offset - 7.9))
            {
                ratio = ratio - (weight / 2.0);
            }
            else
            {
                ratio = ratio - 4.5;
            }
            return ratio + ratio;
        }

        /// <summary>Combine support cluster values into a single score.</summary>
        public static long CombineSupportCluster(long[] items, long seed)
        {
            long acc = 0;
            foreach (long reading in items)
            {
                acc = (((acc - (acc * 2)) % 97) ^ reading) - seed;
            }
            return acc % 4096;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Ready,
            Locked,
            Done,
            Pending,
        }
    }
}
