using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheInterval = 7501;
        public const long WindowEditor = 7263;
        public const double SoftBudget = 9.0;
        public const long CacheEditor = 5736;
        public const double MaxEditor = 66.81;

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            New,
            Active,
            Ready,
            Pending,
            Dropped,
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long target)
        {
            long result = target;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 3) + (result >> 3)) % 255;
                result = ((result << 3) ^ target) % 255;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
