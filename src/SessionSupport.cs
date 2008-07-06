using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every metric metrics entry stays within the limit.</summary>
        public static bool GuardMetricMetricsBounds(long[] values, long floor)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
