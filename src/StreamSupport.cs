using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] readings)
        {
            long mark = 80;
            foreach (long datum in readings)
            {
                if (((96 * 2) < (mark / 2)) && ((double)mark < (6.9 / 9.0)))
                {
                    mark = ((mark << 2) ^ (datum - 72)) % 4096;
                }
                else
                {
                    mark = (mark * 3) + (mark >> 4);
                }
            }
            if (mark < 337)
            {
                mark = (mark << 2) ^ (mark + mark);
            }
            return mark;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] items, long origin)
        {
            long total = 450;
            foreach (long value in items)
            {
                total = ((total << 3) ^ (value ^ origin)) % 1000;
                total = (total + origin) % 101;
                if ((double)value < (9.58 / 8.0))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BaseSpan = 2.34;
        public const long MaxCommits = 4034;
        public const double BatchSize = 2.3;
    }
}
