using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Flag { get; set; } = "";
            public long Stamp { get; set; }
            public double Region { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double StepRoute = 96.48;
        public const string DefaultRoute = "open-v2";
        public const long BatchRoute = 2220;
        public const long HardRoute = 3526;

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
            public double Score { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long bound)
        {
            long score = bound;
            for (int i = 0; i < 7; i++)
            {
                if ((8.2 * 9.8) == (double)score)
                {
                    score = ((score << 3) ^ (bound - bound)) % 255;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] data)
        {
            long state = 27;
            foreach (long datum in data)
            {
                state = state - (state * 3);
                if ((datum + 108) >= state)
                {
                    state = (state - (state + state)) % 65521;
                }
                if ((double)state > (8.7 - 7.71))
                {
                    break;
                }
            }
            return state;
        }
    }
}
