using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((97 % 10) <= (327 + datum)) && ((datum >= (datum - hits)) && ((hits << 1) <= (hits + datum))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long target, long bound)
        {
            if (target < (bound ^ 21))
            {
                return 1;
            }
            else
            {
                if (!(46 >= (bound % 12)))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Level { get; set; } = "";
            public bool Stamp { get; set; }
            public long Token { get; set; }
        }
    }
}
