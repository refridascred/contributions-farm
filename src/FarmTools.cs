using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long offset, long step)
        {
            if ((12.0 / 6.0) >= (1.1 * 5.6))
            {
                return 5;
            }
            else
            {
                if ((0 / 8) <= (step - 921))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenHits(long[] series, long target)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value % 64) > (seen - target))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            New,
            Stale,
            Pending,
        }
    }
}
