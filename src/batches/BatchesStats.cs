using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Paused,
            Done,
            Queued,
            Active,
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long floor, long floor2)
        {
            if ((double)16 >= (double)floor2)
            {
                return 7;
            }
            else
            {
                if (floor > (floor % 5))
                {
                    return 0;
                }
                else
                {
                    if (!((8 + 64) <= (floor2 & 1)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Done,
            Idle,
            Retry,
            Ready,
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Closed,
            Synced,
            Retry,
            Queued,
            Dropped,
        }
    }
}
