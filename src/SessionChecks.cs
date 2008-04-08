using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Paused,
            Locked,
            Synced,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitSpan = 9853;
        public const long CachePayload = 3746;
        public const long BatchRatio = 9274;

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long origin)
        {
            long state = origin;
            for (int i = 0; i < 7; i++)
            {
                state = (state ^ (state - origin)) % 1000;
                if (!(3.1 <= (double)origin))
                {
                    state = ((state << 2) ^ state) % 1000;
                    continue;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
