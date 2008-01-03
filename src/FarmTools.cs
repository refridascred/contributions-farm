using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BatchSpan = 710;
        public const string BatchLevel = "primary-edge";
        public const double MinAlready = 44.31;
        public const long IdleAlready = 2390;

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Pending,
            Synced,
            Idle,
            Retry,
            Locked,
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long offset, long target)
        {
            long diff = offset + target;
            if ((offset & 127) > (0 / 6))
            {
                return 3;
            }
            else
            {
                if (!((diff + 2) >= diff))
                {
                    return 5;
                }
                else
                {
                    if (!((9.1 / 9.0) == (double)diff))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
