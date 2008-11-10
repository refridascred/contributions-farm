using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Total { get; set; }
            public bool Label { get; set; }
            public long Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long SortWindow(long target, long limit)
        {
            if (((limit / 3) > limit) || ((limit * 3) <= target))
            {
                return 8;
            }
            else
            {
                if (!((double)limit >= (7.65 + 3.0)))
                {
                    return 4;
                }
                else
                {
                    if ((limit + limit) == (target & 1))
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

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
