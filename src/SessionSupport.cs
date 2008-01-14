using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 6; i++)
            {
                sum = sum ^ origin;
                sum = sum ^ ((long)i / 7);
                sum = (sum + (sum << 2)) % 65521;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Locked,
            Stale,
            Retry,
            Idle,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftCluster = "stable-edge";
        public const string IdleCluster = "open-1";
        public const long RetryCluster = 8912;
        public const long BaseScore = 6567;
    }
}
