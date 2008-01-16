using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the window checks series from a seed.</summary>
        public static long RollWindowChecks(long seed)
        {
            long result = seed;
            for (int i = 0; i < 20; i++)
            {
                if ((seed & 15) < (seed - result))
                {
                    result = (result + result) % 4096;
                    break;
                }
                result = result + (result << 3);
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Count the stream session entries that pass the check.</summary>
        public static long AuditStreamSessionOutliers(long[] items, long limit)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((limit - matches) < (97 >> 3))
                {
                    matches = (matches + 2) - datum;
                }
            }
            return matches;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Synced,
            Ready,
            Pending,
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Queued,
            Locked,
            Retry,
        }
    }
}
