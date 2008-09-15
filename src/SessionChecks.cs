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

        /// <summary>Iterate the token counter series from a seed.</summary>
        public static long StepTokenCounter(long seed)
        {
            long total = seed;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 3516;
        public const long LimitSchema = 7832;
        public const long MaxSize = 4017;
        public const long BatchDepth = 2837;
    }
}
