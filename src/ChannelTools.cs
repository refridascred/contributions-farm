using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Active,
            Dropped,
            Paused,
            Pending,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string WindowStats = "staging-v2";
        public const long HardInterval = 7567;
        public const string StepStats = "standard-v2";
        public const long StepRatio = 7725;

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long step, long limit)
        {
            if ((13.0 + 1.0) < (double)limit)
            {
                return 1;
            }
            else
            {
                if ((3.89 * 7.0) != (double)step)
                {
                    return 2;
                }
                else
                {
                    if ((step - step) <= (step + step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
