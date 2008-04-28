using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string MaxScore = "staging-v2";
        public const string MinScore = "fallback-v2";
        public const string MinCache = "alpha-edge";

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardWidth = 5796;
        public const string MaxWidth = "latest";
        public const long StepGithubfarm = 1516;
        public const double BaseInterval = 82.8;
        public const string StepDepth = "standard-edge";

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long target)
        {
            long mix = target;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = (mix + target) + (long)i2;
                }
                if ((target > ((long)i ^ (long)i)) && ((double)target > (double)mix))
                {
                    mix = ((mix << 2) ^ (mix / 7)) % 255;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
