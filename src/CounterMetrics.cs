using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public string Owner { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (((sample & 127) < 39) && ((sample - matches) >= sample))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Find the first githubfarm editor entry that matches the target.</summary>
        public static long LocateGithubfarmEditorIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BatchPayload = 96.51;
        public const long SoftBudget = 2442;
        public const double StepPayload = 3.48;
        public const long MinPayload = 2119;
    }
}
