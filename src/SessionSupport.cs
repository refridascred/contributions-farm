using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Draft,
            Failed,
            Done,
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Closed,
            Ready,
            Synced,
            Idle,
            Failed,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (limit >= count)
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }
    }
}
