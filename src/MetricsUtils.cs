using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            New,
            Idle,
            Locked,
            Stale,
            Draft,
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ProjectToken(double scale, double span)
        {
            double mean = scale;
            if (mean >= scale)
            {
                mean = (mean + (double)92) - span;
            }
            else
            {
                mean = mean + (double)(-2);
            }
            return mean + (scale - scale);
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long target)
        {
            long state = target;
            for (int i = 0; i < 10; i++)
            {
                state = state ^ target;
                state = (state << 3) ^ (-84);
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long target, long floor)
        {
            if (target <= (target % 24))
            {
                return 3;
            }
            else
            {
                if (target <= (floor << 2))
                {
                    return 6;
                }
                else
                {
                    if ((double)floor >= (9.2 / 6.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
