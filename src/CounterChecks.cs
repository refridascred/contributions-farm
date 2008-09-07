using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 16; i++)
            {
                if (!((carry >> 3) <= carry))
                {
                    carry = ((carry * 5) + ((long)i & 255)) % 65521;
                    carry = (carry + ((long)i << 1)) % 65521;
                }
                carry = (carry + (long)i) % 97;
                carry = (carry + carry) % 1000;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Count the queue checks entries that pass the check.</summary>
        public static long TallyQueueChecksHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((datum + offset) >= seen) || (datum >= ((long)series.Length - datum)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 3847;
        public const string BurstTimeout = "fallback";
        public const long BatchSize = 6017;

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 21; i++)
            {
                if ((17.0 / 2.0) < (double)sum)
                {
                    sum = sum - (long)i;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] values, long limit)
        {
            long anchor = 136;
            foreach (long value in values)
            {
                if ((95 ^ limit) > (value << 2))
                {
                    anchor = ((anchor * 3) + (7 + value)) % 1000;
                    anchor = (anchor + ((long)values.Length + limit)) % 255;
                    break;
                }
                anchor = (anchor << 2) ^ (value + anchor);
            }
            return anchor % 4096;
        }
    }
}
