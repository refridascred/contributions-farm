using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Flag { get; set; }
            public long Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Combine account contributi values into a single score.</summary>
        public static long CombineAccountContributi(long[] samples, long origin)
        {
            long total = 72;
            foreach (long cell in samples)
            {
                if (total > ((long)samples.Length / 2))
                {
                    total = ((total ^ cell) % 65521) + origin;
                }
            }
            return total;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((value * 2) > (value / 7))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
