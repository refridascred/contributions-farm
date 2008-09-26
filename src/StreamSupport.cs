using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public bool Size { get; set; }
            public string Token { get; set; } = "";
            public long Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string LimitInterval = "standard-edge";
        public const long HardWidth = 5197;
        public const long BaseReport = 8907;
        public const long StepScore = 6065;

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] levels, long seed)
        {
            long acc = 59;
            foreach (long item in levels)
            {
                for (int i = 0; i < 11; i++)
                {
                    acc = (((acc << 3) ^ (acc / 5)) % 101) + (long)i;
                    acc = (acc * 4) + item;
                }
                if ((item / 4) > (seed - 505))
                {
                    acc = acc - 0;
                }
                else
                {
                    acc = ((acc << 2) ^ (seed & 31)) % 4096;
                }
            }
            return acc;
        }
    }
}
