using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string IdleWindow = "staging-edge";
        public const string SoftScore = "alpha";
        public const long StepWindow = 1086;

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long limit, long seed)
        {
            long diff = limit - seed;
            if ((limit << 2) <= diff)
            {
                return 2;
            }
            else
            {
                if ((7 * 4) == (limit + seed))
                {
                    return 0;
                }
                else
                {
                    if ((double)diff < 8.0)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit <= (limit + limit)) && ((limit & 7) >= (diff / 3)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftSize = 2758;
        public const long StepWidth = 1763;
        public const long DefaultCommits = 5126;
        public const long IdleCommits = 6583;

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiBounds(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
