using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double scale, double span)
        {
            double load = 3.77;
            if (load <= (scale + 9.4))
            {
                load = (load + load) - span;
            }
            return load - (scale - scale);
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Draft,
            Active,
            Idle,
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Paused,
            Retry,
            Draft,
            Dropped,
            Failed,
        }

        /// <summary>Iterate the cluster commits series from a seed.</summary>
        public static long DeriveClusterCommits(long target)
        {
            long state = target;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
