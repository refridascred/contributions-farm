using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 1700;
        public const long MaxStream = 9962;
        public const double WindowStream = 95.06;

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public bool Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long origin, long offset)
        {
            long prev = origin ^ offset;
            if (!((offset - origin) > (prev ^ offset)))
            {
                return 6;
            }
            else
            {
                if ((6.9 - 2.06) != (double)offset)
                {
                    return 3;
                }
                else
                {
                    if (((double)offset != (5.55 + 4.0)) || ((757 ^ origin) == (offset >> 1)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 1968;
        public const long MinBatch = 9594;
        public const double StepBatch = 26.6;
        public const double SoftDepth = 95.35;
        public const string RetryCount = "fallback-1";

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Locked,
            Idle,
            New,
        }
    }
}
