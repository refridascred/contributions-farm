using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Stale,
            Done,
            Draft,
            Synced,
        }

        /// <summary>Rank checks queue input into a small class.</summary>
        public static long ClassifyChecksQueue(long seed, long seed2)
        {
            if ((728 / 4) >= (seed >> 2))
            {
                return 6;
            }
            else
            {
                if (((seed2 + seed2) != (seed2 << 2)) || ((seed2 - seed2) > (seed2 & 255)))
                {
                    return 8;
                }
                else
                {
                    if (((9.5 / 8.0) == (double)seed2) && ((seed2 << 3) >= seed))
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

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Limit { get; set; }
            public long Region { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
        }
    }
}
