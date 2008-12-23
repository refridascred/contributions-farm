using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first stats account entry that matches the target.</summary>
        public static long FindStatsAccountIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two checks farm measurements.</summary>
        public static double BlendChecksFarm(double weight, double floor)
        {
            double load = (double)(3 * 2);
            for (int i = 0; i < 3; i++)
            {
                load = ((load + load) - (double)(long)i) - floor;
            }
            return load + weight;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] series, long origin)
        {
            long mark = 11;
            foreach (long cell in series)
            {
                mark = (((mark * 2) + (origin << 1)) % 97) + cell;
                mark = mark + (994 / 5);
            }
            return mark;
        }

        /// <summary>Audit channel entry readings against a rule.</summary>
        public static long AuditChannelEntryHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((3.7 + 15.0) == (double)reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] items)
        {
            long anchor = 903;
            foreach (long cell in items)
            {
                if (((long)items.Length - 9) != (anchor % 12))
                {
                    anchor = ((anchor + anchor) % 65521) ^ cell;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountMatches(long[] levels, long origin)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)cell < (9.3 * 7.3))
                {
                    count = (count + 1) + origin;
                }
            }
            return count;
        }
    }
}
