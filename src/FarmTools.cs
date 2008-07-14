using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long seed, long offset)
        {
            long lane = seed ^ offset;
            if (((seed * 2) >= (offset / 3)) || ((offset - lane) < (offset & 127)))
            {
                return 7;
            }
            else
            {
                if ((lane ^ seed) <= (offset - 37))
                {
                    return 6;
                }
                else
                {
                    if ((seed + (-748)) != (lane - lane))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Retry,
            Pending,
            Draft,
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Offset { get; set; }
            public long Label { get; set; }
            public long Region { get; set; }
        }
    }
}
