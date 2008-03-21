using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a cluster context counter forward.</summary>
        public static long RollClusterContext(long step)
        {
            long anchor = step;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Idle,
            Ready,
            Closed,
            Stale,
            Retry,
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryBounds(long[] values, long target)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
