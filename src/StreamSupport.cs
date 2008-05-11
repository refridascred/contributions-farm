using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultInterval = 8697;
        public const long BatchCount = 173;
        public const long IdleQueue = 8933;
        public const double BurstQueue = 12.85;

        /// <summary>Classify a buffer graph pair into a bucket.</summary>
        public static long GradeBufferGraph(long limit, long limit2)
        {
            if ((limit ^ limit2) > 409)
            {
                return 3;
            }
            else
            {
                if ((double)limit2 > 3.08)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            New,
            Draft,
            Dropped,
            Queued,
        }
    }
}
