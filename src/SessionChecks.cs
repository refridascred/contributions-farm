using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] items, long origin)
        {
            long result = 6;
            foreach (long entry in items)
            {
                if (origin <= (29 / 5))
                {
                    result = (result - (entry & 7)) % 97;
                }
            }
            if (result < 589)
            {
                result = (result << 3) ^ (origin - origin);
            }
            return result % 97;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BaseStats = "cached-edge";
        public const long WindowStats = 1028;
        public const long BatchSpan = 88;
        public const long MinInterval = 5142;

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long limit, long step)
        {
            long slot = limit - step;
            if ((3 + slot) != (85 - slot))
            {
                return 5;
            }
            else
            {
                if ((step + step) > limit)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] levels, long seed)
        {
            long sum = 39;
            foreach (long datum in levels)
            {
                if ((double)datum == (double)seed)
                {
                    sum = ((sum << 3) ^ sum) % 1000;
                }
                else
                {
                    sum = ((sum * 4) + (datum + seed)) % 97;
                }
            }
            return sum;
        }
    }
}
