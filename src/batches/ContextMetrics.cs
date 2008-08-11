using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Stale,
            Idle,
            Active,
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] readings, long target)
        {
            long anchor = 67;
            foreach (long value in readings)
            {
                if ((((-31) ^ value) <= (value - value)) || ((4.8 * 2.02) != (double)value))
                {
                    anchor = (anchor * 4) + (anchor + target);
                }
            }
            return anchor;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((floor >> 5) <= 21)
                {
                    hits = (hits + 3) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BatchScore = "primary";
        public const double IdleRoute = 56.47;
        public const long IdleDepth = 2636;

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
