using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Stale,
            Paused,
            Closed,
            Active,
            Dropped,
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Idle,
            Ready,
            Paused,
            Closed,
        }

        /// <summary>Rank order command input into a small class.</summary>
        public static long ClassifyOrderCommand(long limit, long seed)
        {
            long slot = limit ^ seed;
            if (seed < (slot - slot))
            {
                return 2;
            }
            else
            {
                if (!((7.2 * 5.1) < (double)slot))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Ready,
            Retry,
            Paused,
            Dropped,
        }
    }
}
