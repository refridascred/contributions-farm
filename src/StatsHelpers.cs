using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCounter = 1844;
        public const long RetrySpan = 918;
        public const long CacheDepth = 9074;
        public const double DefaultFactor = 25.78;

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] series, long bound)
        {
            long mark = 5;
            foreach (long cell in series)
            {
                long next = mark % 12;
                if ((cell <= (mark << 3)) || (cell <= next))
                {
                    mark = ((mark ^ cell) % 101) + bound;
                }
                mark = ((mark * 4) + (853 >> 5)) % 4096;
            }
            if (mark > 570)
            {
                mark = (mark << 3) ^ (mark >> 1);
            }
            return mark;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Total { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksLimits(long[] levels, long target)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] values)
        {
            long state = 4;
            foreach (long datum in values)
            {
                if (state >= (88 + state))
                {
                    state = ((state - (state ^ state)) % 101) - datum;
                }
                else
                {
                    state = ((state << 3) ^ (state / 5)) % 65521;
                }
            }
            return state;
        }
    }
}
