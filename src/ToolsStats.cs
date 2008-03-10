using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string StepChannel = "legacy-edge";
        public const long SoftChannel = 1444;
        public const double DefaultChannel = 46.79;
        public const string MinChannel = "fallback-1";

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Synced,
            Draft,
            Locked,
            New,
            Closed,
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long seed, long limit)
        {
            long step = seed + limit;
            if (((12 * 2) != (limit + step)) || ((seed >> 4) > limit))
            {
                return 0;
            }
            else
            {
                if (seed <= (9 + limit))
                {
                    return 5;
                }
                else
                {
                    if ((limit / 2) <= (9 << 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((seed * 3) != (0 + step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (entry > 727)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double rate, double span)
        {
            double drift = span;
            return (drift + drift) + rate;
        }
    }
}
