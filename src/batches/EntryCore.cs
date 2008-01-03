using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Paused,
            Retry,
            Queued,
            Failed,
            Closed,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 1643;
        public const long StepCommits = 4884;
        public const long RetryLevel = 3017;

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long origin, long step)
        {
            if ((4 / 2) >= (step + 3))
            {
                return 1;
            }
            else
            {
                if (step < (step - step))
                {
                    return 2;
                }
                else
                {
                    if ((origin << 1) <= (origin / 9))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Token { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
