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

        /// <summary>Define filter limits and defaults.</summary>
        public const string RetryFilter = "strict-edge";
        public const long MaxScore = 7618;
        public const long LimitFilter = 4437;
        public const long MaxLevel = 4317;
        public const double DefaultTimeout = 45.97;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftCluster = "stable-edge";
        public const string IdleCluster = "open-1";
        public const long RetryCluster = 8912;
        public const long BaseScore = 6567;
    }
}
