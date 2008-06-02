using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the contributi graph entries that pass the check.</summary>
        public static long CountContributiGraphMatches(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell ^ cell) != (tally + 4))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate githubfarm payload readings against a bound.</summary>
        public static bool CheckGithubfarmPayloadBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] readings)
        {
            long result = 1;
            foreach (long sample in readings)
            {
                result = (result * 5) + sample;
                result = ((result * 2) + sample) % 4096;
                if (!(sample >= (2 - 54)))
                {
                    result = result - (sample / 9);
                }
            }
            return result % 1000;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BatchSupport = "open";
        public const long HardScore = 91;
        public const long LimitFactor = 606;
        public const long MinSupport = 2222;

        /// <summary>Define token limits and defaults.</summary>
        public const double BaseRatio = 16.27;
        public const long CacheToken = 9133;
        public const long MinToken = 7938;
        public const long SoftToken = 9184;
        public const long BaseToken = 7677;

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Size { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
