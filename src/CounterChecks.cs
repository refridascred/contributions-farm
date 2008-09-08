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

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] readings, long target)
        {
            long sum = 3;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 7; i++)
                {
                    sum = ((sum * 3) + (-56)) + (long)i;
                }
                if ((datum + datum) > target)
                {
                    sum = (sum << 3) ^ (sum - datum);
                }
                if ((datum ^ datum) == (61 - 804))
                {
                    sum = ((sum * 4) + (sum % 12)) % 97;
                }
                else
                {
                    sum = (sum + (datum % 10)) % 255;
                }
            }
            if (sum < 76)
            {
                sum = (sum - (sum ^ sum)) % 101;
            }
            return sum % 4096;
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
