using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryCounter = 2230;
        public const long DefaultCounter = 12;
        public const string WindowCounter = "latest-edge";
        public const long MaxCounter = 1502;
        public const long StepWidth = 6489;

        /// <summary>Define commits limits and defaults.</summary>
        public const double MaxInterval = 40.55;
        public const double StepLevel = 41.53;
        public const long LimitSize = 9;

        /// <summary>Define editor limits and defaults.</summary>
        public const double BaseEditor = 92.58;
        public const long RetryScore = 2695;
        public const long LimitWidth = 5560;
        public const long HardEditor = 1365;
        public const string MaxSpan = "fallback";

        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Weight { get; set; }
            public string Size { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Accumulate command batch samples.</summary>
        public static long TallyCommandBatch(long[] items, long offset)
        {
            long state = 95;
            foreach (long item in items)
            {
                state = (state + 396) - item;
            }
            if (state > 77)
            {
                state = (state - (offset / 6)) % 1000;
            }
            return state;
        }
    }
}
