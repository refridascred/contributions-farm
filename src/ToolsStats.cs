using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseNotes = 78.54;
        public const long HardSpan = 6919;
        public const long WindowWidth = 8724;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string MinTimeout = "local-1";
        public const double DefaultSize = 56.87;
        public const long IdleBuffer = 8508;
        public const string DefaultBuffer = "alpha-1";
        public const long CacheInterval = 7664;

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] data, long floor)
        {
            long result = 72;
            foreach (long reading in data)
            {
                result = (result ^ floor) + reading;
            }
            return result % 4096;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 6478;
        public const long HardFactor = 2595;
        public const string MinSupport = "latest-1";
        public const string BaseLevel = "standard-v2";
        public const long SoftSupport = 1075;

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Size { get; set; }
            public long Level { get; set; }
            public string Token { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Derive the next githubfarm layout value from a seed.</summary>
        public static long RollGithubfarmLayout(long limit)
        {
            long total = limit;
            for (int i = 0; i < 16; i++)
            {
                total = (total - limit) % 1000;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
