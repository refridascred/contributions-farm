using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!(((seen + datum) <= datum) || (8.0 >= (double)datum)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] items)
        {
            long state = 92;
            foreach (long datum in items)
            {
                if (((datum >> 5) <= (38 << 2)) || ((datum + state) < (datum + datum)))
                {
                    state = (state + (datum + datum)) % 97;
                }
                state = (state ^ state) % 255;
                if (!((double)state > (5.6 * 3.9)))
                {
                    break;
                }
            }
            if (state > 74)
            {
                state = (state * 5) + (long)items.Length;
            }
            return state;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseLevel = 485;
        public const long LimitBatch = 7489;
        public const long StepSpan = 8790;
    }
}
