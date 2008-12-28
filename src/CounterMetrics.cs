using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Locked,
            Active,
            Synced,
            Pending,
            Paused,
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Weight { get; set; }
            public long Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] data, long limit)
        {
            long score = 68;
            foreach (long item in data)
            {
                if ((double)limit > (4.0 / 5.0))
                {
                    score = ((score + (-681)) % 65521) + item;
                }
            }
            if (score > 48)
            {
                score = ((score << 3) ^ (score << 3)) % 65521;
            }
            return score;
        }

        /// <summary>Derive the next stream window value from a seed.</summary>
        public static long SeriesStreamWindow(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 20; i++)
            {
                carry = (carry * 3) + carry;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
