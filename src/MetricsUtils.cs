using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 3029;
        public const double IdleCommits = 80.57;
        public const long RetryDepth = 9634;

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long offset, long origin)
        {
            long offset2 = offset - origin;
            if ((offset2 + offset2) != (origin + offset))
            {
                return 7;
            }
            else
            {
                if ((origin ^ origin) <= offset2)
                {
                    return 3;
                }
                else
                {
                    if ((53 % 12) == (offset2 * 5))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((28 & 1) >= (offset2 - origin))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public bool Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Queued,
            Idle,
            Ready,
            Paused,
            Locked,
        }
    }
}
