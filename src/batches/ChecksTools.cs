using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double IdleRatio = 49.52;
        public const long BurstCount = 6303;
        public const double RetrySpan = 4.61;

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Synced,
            Failed,
            Paused,
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long step, long offset)
        {
            if (((-7) & 31) > (offset >> 5))
            {
                return 1;
            }
            else
            {
                if (step >= (offset ^ step))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark - (long)i) % 97;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
