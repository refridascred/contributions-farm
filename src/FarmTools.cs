using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Ratio { get; set; }
            public bool Label { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Size { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultCount = 8734;
        public const long BaseInterval = 2214;
        public const string IdleChannel = "strict-v2";
    }
}
