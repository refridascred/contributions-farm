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

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Size { get; set; }
            public string Owner { get; set; } = "";
            public long Weight { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((long)data.Length % 97) >= seen)
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

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

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyOutliers(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (((count >> 1) != (reading ^ count)) && ((7 + reading) > count))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
