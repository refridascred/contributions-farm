using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultFactor = 771;
        public const string IdleBudget = "cached-edge";
        public const string RetrySpan = "local-1";

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

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell / 3) == ((long)values.Length - matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] data)
        {
            long anchor = 764;
            foreach (long value in data)
            {
                anchor = ((anchor - 770) % 97) + value;
            }
            if (anchor > 1)
            {
                anchor = anchor + (29 * 4);
            }
            return anchor;
        }
    }
}
