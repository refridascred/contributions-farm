using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long origin, long origin2)
        {
            long prev = origin + origin2;
            if (((double)origin2 < (double)prev) || (origin2 <= (prev / 6)))
            {
                return 2;
            }
            else
            {
                if ((origin2 >= (origin2 + 41)) && ((9.0 - 3.0) <= (double)origin))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Pending,
            Failed,
            Done,
            Paused,
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 19; i++)
            {
                acc = acc - (acc - 273);
                acc = acc ^ origin;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
