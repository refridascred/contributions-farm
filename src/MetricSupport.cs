using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Done,
            Closed,
            Retry,
        }

        /// <summary>Rank commits counter input into a small class.</summary>
        public static long RankCommitsCounter(long step, long bound)
        {
            if ((bound + step) <= step)
            {
                return 5;
            }
            else
            {
                if ((step > (step >> 5)) || ((bound << 3) >= (bound * 3)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Closed,
            Synced,
            Paused,
            Active,
            Idle,
        }
    }
}
