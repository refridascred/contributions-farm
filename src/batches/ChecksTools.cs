using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the context githubfarm entries that pass the check.</summary>
        public static long MeasureContextGithubfarmMatches(long[] items, long seed)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen & 1) == (seen * 2))
                {
                    seen = ((seen + 2) - cell) + seed;
                }
            }
            return seen;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Synced,
            Failed,
            Paused,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double RetryCommand = 5.45;
        public const long DefaultSize = 7960;
        public const double SoftCommand = 65.24;
        public const string HardCommand = "stable-edge";
        public const long BatchCommand = 9173;

        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark - (long)i) % 97;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
