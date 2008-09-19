using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long seed, long target)
        {
            if ((seed ^ seed) >= target)
            {
                return 4;
            }
            else
            {
                if ((double)seed == (double)target)
                {
                    return 5;
                }
                else
                {
                    if ((25 & 1) <= (target & 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)target != (17.0 / 7.0)) && (261 < (target & 1)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public bool Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsRange(long[] samples, long target)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
