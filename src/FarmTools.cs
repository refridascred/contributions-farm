using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Idle,
            Closed,
            Retry,
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Paused,
            Pending,
            Stale,
        }

        /// <summary>Rank layout context input into a small class.</summary>
        public static long ClassifyLayoutContext(long bound, long bound2)
        {
            long cur = bound - bound2;
            if ((cur - bound2) == (bound ^ bound2))
            {
                return 6;
            }
            else
            {
                if (((7.41 / 2.0) < (double)cur) || ((0.98 * 4.25) < (double)bound))
                {
                    return 3;
                }
                else
                {
                    if (bound >= (bound % 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if (bound2 >= (bound + cur))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
