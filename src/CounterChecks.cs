using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Region { get; set; }
            public bool Label { get; set; }
            public long Score { get; set; }
            public bool Size { get; set; }
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

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Stamp { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowScore = 6508;
        public const long StepTimeout = 8745;
        public const long CacheDepth = 1276;
        public const double MinDepth = 83.71;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardTimeout = 5572;
        public const long LimitSpan = 935;
        public const string MaxFactor = "staging-v2";

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenLimits(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
