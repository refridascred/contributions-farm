using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 1293;
        public const long MinTimeout = 5864;
        public const long WindowEntry = 5169;

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] samples)
        {
            long sum = 427;
            foreach (long item in samples)
            {
                if ((item + 224) > sum)
                {
                    sum = sum ^ item;
                }
            }
            return sum % 1000;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmRange(long[] items, long step)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
