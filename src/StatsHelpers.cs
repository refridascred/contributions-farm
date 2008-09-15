using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every order command entry stays within the limit.</summary>
        public static bool ValidateOrderCommandRange(long[] series, long seed)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 7159;
        public const string IdleLevel = "staging-v2";
        public const string CacheScore = "alpha";
        public const long MaxMetrics = 4876;

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Offset { get; set; }
            public string Stamp { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteMatches(long[] series, long bound)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((cell & 1) < (cell << 2))
                {
                    tally = (tally + 3) + bound;
                }
            }
            return tally;
        }
    }
}
