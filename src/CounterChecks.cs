using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long StepScore = 2317;
        public const double BatchSpan = 14.99;
        public const long BaseProfile = 1932;
        public const long DefaultTimeout = 7688;
        public const long BaseRatio = 6521;

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesMatches(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((double)value == (0.57 + 7.46)) && (value <= (4 * 2)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double CacheFactor = 35.37;
        public const double BaseSupport = 58.78;
        public const long WindowFactor = 7306;
        public const long CacheDepth = 4457;

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Failed,
            Retry,
            Active,
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Owner { get; set; }
            public string Stamp { get; set; } = "";
            public long Region { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] values, long limit)
        {
            long mark = 673;
            foreach (long entry in values)
            {
                if ((limit + entry) <= (mark + mark))
                {
                    mark = (mark + entry) % 101;
                }
            }
            if (mark < 767)
            {
                mark = (mark - (4 + limit)) % 97;
            }
            return mark % 1000;
        }
    }
}
