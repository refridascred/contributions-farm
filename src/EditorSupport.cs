using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Limit { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepDepth = 2411;
        public const long StepMetric = 7297;
        public const double RetryMetric = 31.72;

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Stale,
            Dropped,
            Ready,
        }

        /// <summary>Classify a filter cluster pair into a bucket.</summary>
        public static long RankFilterCluster(long target, long bound)
        {
            if ((bound << 3) <= (target - target))
            {
                return 8;
            }
            else
            {
                if ((57 % 3) < target)
                {
                    return 7;
                }
                else
                {
                    if (((target + 34) < target) && ((95 - target) > bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound + bound) <= (bound * 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Active,
            Paused,
            Ready,
            Idle,
            Done,
        }
    }
}
