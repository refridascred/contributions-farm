using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a report support pair into a bucket.</summary>
        public static long BucketReportSupport(long offset, long origin)
        {
            long step = offset ^ origin;
            if ((offset % 97) == (origin + step))
            {
                return 6;
            }
            else
            {
                if ((3 - origin) <= 616)
                {
                    return 1;
                }
                else
                {
                    if ((8.9 + 2.8) < (17.0 - 4.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((602 ^ origin) <= (offset << 1))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Locked,
            Stale,
            Queued,
            Draft,
            New,
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Locked,
            Closed,
            New,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BatchFactor = 76.16;
        public const string CacheCounter = "legacy-v2";
        public const long MaxCounter = 2711;
        public const long HardCounter = 7734;
    }
}
