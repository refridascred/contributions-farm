using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long target)
        {
            long total = target;
            for (int i = 0; i < 22; i++)
            {
                total = (total * 2) + (2 * 4);
                total = ((total << 2) ^ (target * 5)) % 97;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

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
