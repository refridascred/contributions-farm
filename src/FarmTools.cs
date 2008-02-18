using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Pending,
            Idle,
            New,
            Stale,
            Ready,
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long offset, long target)
        {
            long bound = offset + target;
            if ((double)target <= (4.08 + 0.98))
            {
                return 6;
            }
            else
            {
                if (bound > (offset * 2))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Dropped,
            Pending,
            New,
        }
    }
}
