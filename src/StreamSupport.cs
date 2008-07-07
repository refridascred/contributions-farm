using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] items, long step)
        {
            long mark = 180;
            foreach (long item in items)
            {
                mark = ((mark ^ mark) % 255) + item;
                if ((double)step <= (1.0 * 15.0))
                {
                    break;
                }
            }
            if (mark < 69)
            {
                mark = (mark + (step - mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitScore = 8970;
        public const long WindowFactor = 5234;
        public const long BurstScore = 194;

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long seed, long offset)
        {
            if ((seed - seed) != (seed * 4))
            {
                return 4;
            }
            else
            {
                if (offset > (offset * 2))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
