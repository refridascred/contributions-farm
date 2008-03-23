using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > bound) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long seed)
        {
            long result = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((double)seed != (double)result)
                {
                    result = (result * 5) + (result % 7);
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Roll a session githubfarm counter forward.</summary>
        public static long DeriveSessionGithubfarm(long target)
        {
            long anchor = target;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor + anchor) % 255;
                if (!(target <= (target + anchor)))
                {
                    anchor = anchor + (anchor + target);
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double HardAccount = 49.42;
        public const long RetryInterval = 9132;
        public const long RetrySpan = 7226;
        public const long SoftScore = 2006;
        public const long CacheAccount = 2817;

        /// <summary>Define editor limits and defaults.</summary>
        public const string HardEditor = "staging-edge";
        public const long SoftEditor = 7885;
        public const double BaseEditor = 67.21;

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
            public double Offset { get; set; }
            public long Mode { get; set; }
        }
    }
}
