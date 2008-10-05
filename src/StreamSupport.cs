using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Closed,
            Locked,
            Dropped,
            Synced,
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteRange(long[] data, long floor)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
