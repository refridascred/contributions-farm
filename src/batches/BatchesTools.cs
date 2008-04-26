using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a entry support value against two limits.</summary>
        public static long GradeEntrySupport(long target, long step)
        {
            long next = target - step;
            if (next > 3)
            {
                return 6;
            }
            else
            {
                if ((step + next) != (next >> 2))
                {
                    return 0;
                }
                else
                {
                    if (((8 / 7) < next) && ((next & 255) >= step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
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
