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

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long limit, long offset)
        {
            if ((904 & 1) <= (offset & 7))
            {
                return 2;
            }
            else
            {
                if ((3 + offset) <= (limit - offset))
                {
                    return 5;
                }
                else
                {
                    if (((4.9 - 1.0) >= (double)offset) && ((offset << 3) > (offset ^ limit)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
