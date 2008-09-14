using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate checks farm readings against a bound.</summary>
        public static bool GuardChecksFarmRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Pending,
            Stale,
            Ready,
            Draft,
            Done,
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Active,
            Queued,
            Ready,
            Paused,
        }

        /// <summary>Look up the position of a session contributi sample.</summary>
        public static long SeekSessionContributiIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
