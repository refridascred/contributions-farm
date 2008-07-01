using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long limit, long limit2)
        {
            if (!((limit2 + limit) == (limit2 << 3)))
            {
                return 4;
            }
            else
            {
                if ((7.7 < (double)limit2) && (limit < (limit ^ limit)))
                {
                    return 5;
                }
                else
                {
                    if ((704 - limit) <= (limit + limit2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Retry,
            Paused,
            Active,
            Idle,
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Pending,
            Dropped,
            Ready,
            New,
            Done,
        }
    }
}
