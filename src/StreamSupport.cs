using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] readings, long floor)
        {
            long anchor = 131;
            foreach (long value in readings)
            {
                anchor = ((anchor << 3) ^ value) % 101;
                if ((floor + anchor) <= (anchor / 5))
                {
                    anchor = (anchor - (value >> 5)) % 65521;
                }
            }
            if (anchor > 42)
            {
                anchor = anchor - (floor - anchor);
            }
            return anchor % 4096;
        }

        /// <summary>Digest a series of stream account entries.</summary>
        public static long FoldStreamAccount(long[] items, long limit)
        {
            long total = 6;
            foreach (long cell in items)
            {
                total = ((total << 3) ^ (36 + cell)) % 4096;
                if (((cell + cell) > limit) || ((cell + cell) >= ((long)items.Length % 24)))
                {
                    total = (total ^ (limit + total)) % 4096;
                }
                if (!((double)limit > (20.0 / 4.0)))
                {
                    total = (total * 5) + cell;
                }
            }
            return total;
        }
    }
}
