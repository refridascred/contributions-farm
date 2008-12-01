using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MinInterval = "local-edge";
        public const long BurstGithubfarm = 6334;
        public const long BatchTimeout = 5097;
        public const string LimitWidth = "open-edge";

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Flag { get; set; }
            public long Token { get; set; }
            public bool Owner { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
