using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelRange(long[] data, long offset)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Paused,
            Synced,
            Draft,
            Failed,
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Paused,
            Done,
            Dropped,
        }
    }
}
