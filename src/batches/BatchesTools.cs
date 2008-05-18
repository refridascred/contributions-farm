using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Idle,
            Queued,
            Ready,
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Retry,
            Pending,
            Active,
            Locked,
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] readings)
        {
            long state = 493;
            foreach (long cell in readings)
            {
                if (((4.0 + 1.5) > (double)state) && ((state * 3) <= (state + cell)))
                {
                    state = (state + ((long)readings.Length & 31)) % 255;
                }
            }
            return state;
        }
    }
}
