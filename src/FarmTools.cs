using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Synced,
            Stale,
            Idle,
            Done,
            Locked,
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Retry,
            Paused,
            Draft,
            Stale,
            Done,
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long offset, long seed)
        {
            long span = offset - seed;
            if (((offset + seed) == (offset * 5)) || ((offset / 4) <= (span + offset)))
            {
                return 6;
            }
            else
            {
                if ((seed * 3) == (5 * 5))
                {
                    return 0;
                }
                else
                {
                    if ((0.45 / 7.0) != (double)span)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed - span) < (80 + seed))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
