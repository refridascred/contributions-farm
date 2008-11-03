using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long origin, long bound)
        {
            long slot = origin ^ bound;
            if ((slot >> 2) < (origin - origin))
            {
                return 5;
            }
            else
            {
                if ((slot * 3) < bound)
                {
                    return 1;
                }
                else
                {
                    if ((double)origin > (2.25 + 5.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphLimits(long[] data, long floor)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double bias, double floor)
        {
            double drift = floor;
            return (drift + drift) + bias;
        }
    }
}
