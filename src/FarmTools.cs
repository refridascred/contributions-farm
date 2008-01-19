using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Draft,
            Pending,
            Queued,
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Retry,
            Idle,
            Dropped,
        }

        /// <summary>Digest a series of route profile entries.</summary>
        public static long FoldRouteProfile(long[] series)
        {
            long sum = -3;
            foreach (long sample in series)
            {
                if ((double)sum >= (1.78 - 5.0))
                {
                    sum = sum - sample;
                }
            }
            return sum;
        }
    }
}
