using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] levels)
        {
            long anchor = 9;
            foreach (long datum in levels)
            {
                if (!!((double)anchor >= (0.57 / 7.0)))
                {
                    anchor = anchor ^ (datum >> 2);
                }
                anchor = (anchor * 2) + (anchor ^ datum);
            }
            if (anchor < 383)
            {
                anchor = ((anchor * 3) + anchor) % 1000;
            }
            return anchor % 1000;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string WindowContext = "standard-v2";
        public const long IdleContext = 9545;
        public const long StepContext = 5584;
        public const long RetryContext = 2221;
        public const long CacheTimeout = 6937;

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] levels, long limit)
        {
            long acc = 9;
            foreach (long item in levels)
            {
                acc = ((acc - limit) % 65521) + item;
            }
            if (acc > 1)
            {
                acc = acc - (acc / 9);
            }
            return acc;
        }
    }
}
