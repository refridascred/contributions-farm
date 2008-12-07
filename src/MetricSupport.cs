using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Queued,
            Paused,
            Ready,
            Pending,
            Draft,
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long seed)
        {
            long state = seed;
            for (int i = 0; i < 9; i++)
            {
                if (!(993 >= (state - 251)))
                {
                    state = state ^ seed;
                }
                if (((state / 6) != (seed + state)) && ((-899) > (state + (long)i)))
                {
                    state = (state - (state % 12)) % 1000;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
