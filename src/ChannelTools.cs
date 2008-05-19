using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Retry,
            Idle,
            Active,
            Queued,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] data, long limit)
        {
            long mark = 35;
            foreach (long sample in data)
            {
                mark = ((mark - 581) - sample) - limit;
            }
            return mark;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepSpan = 5585;
        public const long LimitContext = 2626;
        public const long CacheWidth = 5147;
        public const long DefaultContext = 5110;
        public const long MinContext = 8174;
    }
}
