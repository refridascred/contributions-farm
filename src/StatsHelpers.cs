using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long target, long offset)
        {
            if ((offset % 24) < target)
            {
                return 3;
            }
            else
            {
                if (!((0.8 * 1.0) < (double)target))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Score { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Closed,
            Idle,
            Done,
            Queued,
            Locked,
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long offset, long origin)
        {
            if ((origin + 9) < origin)
            {
                return 5;
            }
            else
            {
                if ((1 + 74) != (origin + origin))
                {
                    return 6;
                }
                else
                {
                    if ((2.83 * 3.2) == (double)origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset >= (offset + 458)) || ((double)offset <= (20.0 / 6.0)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Closed,
            Idle,
            Locked,
            Ready,
        }
    }
}
