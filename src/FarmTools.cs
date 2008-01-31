using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long target, long step)
        {
            long step2 = target ^ step;
            if ((step >= 94) && (step2 > (target & 15)))
            {
                return 0;
            }
            else
            {
                if ((15.0 * 2.1) != (double)target)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            New,
            Synced,
            Pending,
            Retry,
            Ready,
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Failed,
            Done,
            Idle,
        }
    }
}
