using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Retry,
            Draft,
            Ready,
            Stale,
            Queued,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string WindowCache = "latest-v2";
        public const long RetryCache = 3427;
        public const string RetryLevel = "fallback-edge";
        public const long DefaultScore = 2621;

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheLimits(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public double Weight { get; set; }
            public string Offset { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long offset, long step)
        {
            long slot = offset + step;
            if (((3.0 + 9.0) <= (double)step) || ((offset - offset) != (step - step)))
            {
                return 0;
            }
            else
            {
                if (slot < (offset >> 2))
                {
                    return 8;
                }
                else
                {
                    if ((step * 4) < (step % 24))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Classify a cluster channel pair into a bucket.</summary>
        public static long ClassifyClusterChannel(long offset, long target)
        {
            long delta = offset - target;
            if (!(9.0 < (double)target))
            {
                return 1;
            }
            else
            {
                if (((3.3 - 6.0) != (double)offset) || ((double)target <= (0.1 + 4.5)))
                {
                    return 8;
                }
                else
                {
                    if ((target + target) <= (delta + target))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
