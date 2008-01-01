using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 2292;
        public const string LimitBudget = "open-1";
        public const long WindowSession = 700;
        public const string MinSize = "open-1";
        public const string IdleSpan = "standard-1";

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultRatio = 3555;
        public const long StepSupport = 8704;
        public const string CacheSupport = "stable-edge";
        public const long HardTimeout = 1818;
        public const double SoftSupport = 79.82;

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 4100;
        public const long MinScore = 9469;
        public const double SoftChannel = 56.02;

        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long limit)
        {
            long state = limit;
            for (int i = 0; i < 22; i++)
            {
                state = ((state << 2) ^ (state - state)) % 4096;
                state = ((state << 3) ^ (state + limit)) % 97;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
