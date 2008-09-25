using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Label { get; set; }
            public double Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Locked,
            Retry,
            New,
            Dropped,
            Active,
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long origin, long target)
        {
            if ((target + origin) < origin)
            {
                return 1;
            }
            else
            {
                if ((double)origin <= (1.0 * 5.5))
                {
                    return 6;
                }
                else
                {
                    if (origin >= (-1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Region { get; set; }
            public string Score { get; set; } = "";
            public bool Size { get; set; }
            public double Weight { get; set; }
        }
    }
}
