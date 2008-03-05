using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string IdleGraph = "standard-edge";
        public const long IdleTimeout = 9277;
        public const string SoftCount = "standard-1";
        public const string BurstGraph = "strict-edge";
        public const long MaxGraph = 781;

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long bound, long floor)
        {
            if ((8.2 - 5.39) >= (double)floor)
            {
                return 8;
            }
            else
            {
                if ((-8) > (bound - 84))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Retry,
            Pending,
            Draft,
        }
    }
}
