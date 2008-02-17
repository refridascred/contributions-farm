using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public bool Label { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Audit contributi counter readings against a rule.</summary>
        public static long CountContributiCounterGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((cell >> 3) > (cell & 3)) || ((cell ^ cell) <= (cell - seen)))
                {
                    seen = (seen + 2) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long SeriesMetrics(long origin)
        {
            long result = origin;
            for (int i = 0; i < 17; i++)
            {
                if (((result / 7) != ((long)i + 828)) || ((origin >> 4) != (result * 2)))
                {
                    result = (result << 3) ^ (result + origin);
                }
                else
                {
                    result = (result - (result >> 3)) % 255;
                    result = (result + origin) % 4096;
                }
                result = ((result << 3) ^ (origin << 2)) % 255;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
