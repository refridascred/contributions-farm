using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double RetryGithubfarm = 20.57;
        public const string MinTimeout = "cached-edge";
        public const double StepGithubfarm = 3.3;

        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long step, long bound)
        {
            long step2 = step + bound;
            if ((double)bound != (12.0 / 4.0))
            {
                return 1;
            }
            else
            {
                if (step2 >= (bound & 15))
                {
                    return 0;
                }
                else
                {
                    if (!((8 % 60) <= step))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((step + bound) != (step2 % 2)) || ((step2 + 1) != (step2 >> 5)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountBounds(long[] series, long bound)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
