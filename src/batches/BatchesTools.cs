using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long step, long target)
        {
            long cur = step ^ target;
            if ((target - cur) < (cur + step))
            {
                return 1;
            }
            else
            {
                if ((step % 3) <= target)
                {
                    return 7;
                }
                else
                {
                    if (85 < (step * 4))
                    {
                        return 2;
                    }
                    else
                    {
                        if (cur < (step + target))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Stale,
            Paused,
            Closed,
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Paused,
            Done,
            Retry,
        }
    }
}
