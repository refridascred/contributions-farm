using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 8; i++)
            {
                if (!((20.0 + 4.3) == (double)mix))
                {
                    mix = ((mix << 2) ^ (origin & 127)) % 65521;
                    mix = mix - (940 + origin);
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinSpan = 5740;
        public const long CacheFactor = 960;
        public const long CacheCommits = 3669;
        public const string DefaultCommits = "primary";
        public const long RetryBudget = 1328;

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Region { get; set; }
            public double Count { get; set; }
            public double Stamp { get; set; }
        }
    }
}
