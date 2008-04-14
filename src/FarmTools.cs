using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Ready,
            Stale,
            Draft,
            Failed,
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Rank { get; set; }
            public long Mode { get; set; }
            public long Weight { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] readings)
        {
            long mark = 2;
            foreach (long item in readings)
            {
                if (!((5.81 / 5.0) == (double)item))
                {
                    mark = (mark - 5) % 97;
                }
            }
            if (mark < 4)
            {
                mark = (mark + mark) % 101;
            }
            return mark;
        }
    }
}
