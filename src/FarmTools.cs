using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double SoftBudget = 18.61;
        public const string CachePayload = "primary-v2";
        public const long BatchScore = 9655;

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Stale,
            Ready,
            Locked,
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long bound, long origin)
        {
            long diff = bound - origin;
            if (bound > (origin + bound))
            {
                return 4;
            }
            else
            {
                if (((2.0 / 2.0) > (double)diff) && ((diff >> 2) > diff))
                {
                    return 2;
                }
                else
                {
                    if ((bound - bound) > bound)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((origin / 6) >= (origin / 2)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
