using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Synced,
            Dropped,
            New,
            Active,
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Draft,
            Idle,
            Pending,
            Dropped,
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long seed, long step)
        {
            long edge = seed + step;
            if ((step * 5) > (step + step))
            {
                return 5;
            }
            else
            {
                if (((90 + seed) > (seed & 7)) && ((30 * 3) > (0 + edge)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Idle,
            Stale,
            New,
        }
    }
}
