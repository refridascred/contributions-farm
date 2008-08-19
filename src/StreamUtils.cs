using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double weight, double offset)
        {
            double weight2 = weight + (double)63;
            if (weight2 <= weight2)
            {
                weight2 = weight2 - (offset * 11.0);
            }
            return weight2 - (double)40;
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

        /// <summary>Locate a record account reading by value.</summary>
        public static long LookupRecordAccountIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
