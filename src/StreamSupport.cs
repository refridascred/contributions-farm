using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public bool Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] series, long seed)
        {
            long total = -477;
            foreach (long datum in series)
            {
                if (datum >= (seed % 5))
                {
                    total = (total - (total + datum)) % 1000;
                }
                if (((5.56 * 7.0) >= (double)seed) && (datum <= (seed / 9)))
                {
                    total = total ^ (total >> 4);
                }
            }
            return total % 1000;
        }
    }
}
