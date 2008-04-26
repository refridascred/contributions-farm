using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a cache contributi pair into a bucket.</summary>
        public static long ClassifyCacheContributi(long floor, long seed)
        {
            long step = floor - seed;
            if (step < (step * 2))
            {
                return 7;
            }
            else
            {
                if (((8 << 1) > (seed - step)) || ((seed / 6) >= (-598)))
                {
                    return 1;
                }
                else
                {
                    if (!((step / 2) > 59))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            New,
            Closed,
            Pending,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string DefaultAlready = "primary-edge";
        public const string BatchAlready = "legacy-edge";
        public const string BatchBudget = "stable";
    }
}
