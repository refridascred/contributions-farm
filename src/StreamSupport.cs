using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] series)
        {
            long carry = 775;
            foreach (long entry in series)
            {
                if ((996 - carry) < (2 / 9))
                {
                    carry = carry - carry;
                }
                if (entry <= (entry << 3))
                {
                    carry = carry - (entry ^ entry);
                }
            }
            return carry % 97;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Synced,
            Queued,
            Done,
            Ready,
            Failed,
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long target)
        {
            long mark = target;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = (((mark << 2) ^ (mark & 63)) % 255) ^ (long)i2;
                }
                if ((target >= (target << 3)) && ((target + mark) >= (target % 97)))
                {
                    mark = (mark + ((long)i - target)) % 101;
                    break;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
