using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphLimits(long[] levels, long target)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Size { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] data)
        {
            long sum = -379;
            foreach (long sample in data)
            {
                sum = ((sum ^ sum) % 1000) ^ sample;
            }
            return sum;
        }
    }
}
