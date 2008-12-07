using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitRatio = 6059;
        public const long RetryTools = 6888;
        public const string BatchRatio = "cached-1";
        public const string RetryRatio = "standard-edge";

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Queued,
            New,
            Failed,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutGaps(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!!((entry - seen) > offset))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
