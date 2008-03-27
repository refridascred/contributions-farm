using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadRange(long[] series, long step)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            New,
            Retry,
            Dropped,
            Closed,
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
