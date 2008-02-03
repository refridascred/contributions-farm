using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches % 60) >= (matches * 5))
                {
                    matches = ((matches + 1) ^ value) + target;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Closed,
            Queued,
            Paused,
            New,
            Locked,
        }

        /// <summary>Iterate the account buffer series from a seed.</summary>
        public static long IterateAccountBuffer(long step)
        {
            long acc = step;
            for (int i = 0; i < 21; i++)
            {
                if (step > (acc - step))
                {
                    continue;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
