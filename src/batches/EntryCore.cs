using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Weight { get; set; }
            public bool Stamp { get; set; }
            public long Mode { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Locate a githubfarm contributi reading by value.</summary>
        public static long LocateGithubfarmContributiIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 5506;
        public const long CacheCommits = 137;
        public const long HardWidth = 4084;
        public const string BatchScore = "cached-edge";
        public const long BaseDepth = 7346;

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Size { get; set; }
            public string Limit { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long target)
        {
            long carry = target;
            for (int i = 0; i < 16; i++)
            {
                carry = (carry - 782) % 65521;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
