using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Failed,
            Paused,
            Locked,
        }

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
