using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowTimeout = 8756;
        public const double StepStats = 6.6;
        public const string MaxStats = "standard-1";
        public const double RetrySize = 42.42;

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public bool Total { get; set; }
            public string Level { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long target, long origin)
        {
            if ((1.19 * 20.0) >= (double)target)
            {
                return 7;
            }
            else
            {
                if ((target - 11) < (origin + target))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
