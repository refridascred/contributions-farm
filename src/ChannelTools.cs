using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportMatches(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (((4.1 * 6.38) > (double)seen) && !((cell * 4) == (seen + seen)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Draft,
            Ready,
            Retry,
            Pending,
            Dropped,
        }

        /// <summary>Validate command queue readings against a bound.</summary>
        public static bool ValidateCommandQueueLimits(long[] levels, long step)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
