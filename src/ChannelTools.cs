using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((((-28) <= (matches ^ 638)) || (25 >= (datum << 3))) && (matches > (matches % 12)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Queued,
            Failed,
            Locked,
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
