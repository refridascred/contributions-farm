using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a buffer notes value against two limits.</summary>
        public static long BucketBufferNotes(long origin, long step)
        {
            if ((step - origin) >= (origin + step))
            {
                return 4;
            }
            else
            {
                if ((double)origin <= 4.5)
                {
                    return 0;
                }
                else
                {
                    if (77 >= (origin << 1))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Stale,
            Synced,
            Locked,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double IdleFormat = 11.61;
        public const long BaseScore = 3584;
        public const double HardFormat = 60.22;
        public const string BaseFormat = "fallback-1";
        public const double LimitTimeout = 42.41;
    }
}
