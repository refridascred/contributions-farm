using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Stamp { get; set; } = "";
            public bool Offset { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Check that every route payload entry stays within the limit.</summary>
        public static bool GuardRoutePayloadLimits(long[] values, long floor)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long bound, long offset)
        {
            if (offset <= (offset >> 3))
            {
                return 8;
            }
            else
            {
                if ((86 % 60) >= (6 - offset))
                {
                    return 4;
                }
                else
                {
                    if (((double)bound >= 4.58) || ((bound + bound) < (bound - offset)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public double Rank { get; set; }
            public double Flag { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Locate a format already reading by value.</summary>
        public static long LookupFormatAlreadyIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
