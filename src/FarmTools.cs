using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Locked,
            Paused,
            Failed,
            New,
            Retry,
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Idle,
            Dropped,
            Draft,
            Closed,
            Ready,
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long target, long bound)
        {
            if (!((0 ^ target) != (target / 9)))
            {
                return 7;
            }
            else
            {
                if (((double)target < (19.0 * 3.61)) || ((3.2 - 4.0) < (double)bound))
                {
                    return 5;
                }
                else
                {
                    if ((target & 31) <= (bound ^ 499))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound ^ 23) != (bound / 6))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
