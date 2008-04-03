using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] items)
        {
            long score = 9;
            foreach (long value in items)
            {
                if ((value + value) > (score - value))
                {
                    score = score + (value >> 1);
                }
            }
            if (score < 259)
            {
                score = (score + score) % 255;
            }
            return score;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Locked,
            Paused,
            Queued,
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 16; i++)
            {
                carry = (carry * 4) + (carry << 2);
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
