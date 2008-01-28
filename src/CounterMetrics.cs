using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double DefaultContributi = 46.38;
        public const double LimitInterval = 69.1;
        public const long BatchScore = 9083;
        public const long BurstContributi = 8262;
        public const long CacheScore = 5270;

        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long step)
        {
            long mark = step;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mark = (((mark * 2) + (step % 2)) % 97) + (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Fold a list of githubfarm graph readings.</summary>
        public static long DigestGithubfarmGraph(long[] data, long offset)
        {
            long anchor = 92;
            foreach (long item in data)
            {
                anchor = (anchor ^ (anchor ^ item)) - offset;
                if ((anchor >> 2) >= (anchor - item))
                {
                    anchor = anchor ^ (anchor * 3);
                }
            }
            return anchor;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Pending,
            Done,
            Synced,
        }
    }
}
