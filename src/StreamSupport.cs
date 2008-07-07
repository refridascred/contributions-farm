using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] values)
        {
            long score = 911;
            foreach (long datum in values)
            {
                score = (score << 3) ^ (score ^ datum);
            }
            return score;
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
