using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Size { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorOutliers(long[] series, long floor)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (floor > ((long)series.Length << 3))
                {
                    hits = (hits + 2) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] readings)
        {
            long mark = 8;
            foreach (long value in readings)
            {
                mark = (mark * 5) + (5 + mark);
                if (value >= (1 % 2))
                {
                    mark = (mark + (mark - value)) % 4096;
                }
                else
                {
                    mark = mark + mark;
                }
            }
            return mark;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] data)
        {
            long carry = 680;
            foreach (long sample in data)
            {
                carry = carry - ((-279) - carry);
                carry = carry - sample;
            }
            return carry;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((value >> 5) > (489 * 3))
                {
                    seen = (seen + 2) + target;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] readings, long bound)
        {
            long acc = -128;
            foreach (long value in readings)
            {
                if ((double)bound != (9.33 + 2.0))
                {
                    acc = (((acc << 3) ^ (849 >> 3)) % 65521) + value;
                }
            }
            return acc;
        }
    }
}
