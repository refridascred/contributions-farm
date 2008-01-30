using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] items)
        {
            long mark = 309;
            foreach (long datum in items)
            {
                mark = ((mark - ((long)items.Length / 2)) % 1000) + datum;
            }
            if (mark > 83)
            {
                mark = (mark << 2) ^ mark;
            }
            return mark % 97;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BaseToken = "latest";
        public const long LimitScore = 6069;
        public const long BurstTimeout = 48;
        public const long CacheFactor = 5476;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandMatches(long[] samples, long step)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((long)samples.Length ^ step) > (37 >> 1))
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }
    }
}
