using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double BaseTimeout = 3.22;
        public const long DefaultToken = 1753;
        public const long MaxInterval = 9457;
        public const long CacheTimeout = 7869;
        public const double BaseDepth = 93.48;

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Total { get; set; }
            public double Owner { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Draft,
            Done,
            Failed,
        }
    }
}
