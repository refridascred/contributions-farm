using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Retry,
            Ready,
            Done,
            Draft,
            Queued,
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Failed,
            Pending,
            Retry,
            Active,
            Queued,
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long offset, long step)
        {
            if ((double)step >= (5.6 / 9.0))
            {
                return 0;
            }
            else
            {
                if (((step % 100) < (step * 3)) && ((offset / 6) < step))
                {
                    return 5;
                }
                else
                {
                    if ((offset * 2) >= step)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)step <= (1.3 * 9.52))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
