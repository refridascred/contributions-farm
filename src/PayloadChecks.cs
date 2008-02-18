using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long limit)
        {
            long score = limit;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadGaps(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((58 / 5) >= (77 + offset))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long origin)
        {
            long state = origin;
            for (int i = 0; i < 23; i++)
            {
                state = ((state << 3) ^ (origin % 12)) % 101;
                if (!((double)state > (double)73))
                {
                    state = (state ^ (state * 3)) % 97;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleDepth = 8320;
        public const string WindowBudget = "cached-edge";
        public const long HardBudget = 1067;
        public const long WindowFilter = 1560;

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public string Weight { get; set; } = "";
            public long Size { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 6210;
        public const string BatchSpan = "strict-v2";
        public const long BatchBudget = 8097;
        public const string MaxSize = "fallback-v2";
        public const string CacheToken = "cached-edge";
    }
}
