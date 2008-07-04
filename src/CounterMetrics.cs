using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a session context counter forward.</summary>
        public static long SeriesSessionContext(long target)
        {
            long anchor = target;
            for (int i = 0; i < 14; i++)
            {
                if ((5 >> 1) < (anchor >> 1))
                {
                    anchor = (anchor + (588 ^ target)) % 4096;
                    anchor = anchor - 1;
                }
                if (!((double)target > (2.43 / 3.0)))
                {
                    anchor = anchor ^ (target >> 4);
                    anchor = ((anchor << 3) ^ (target ^ (long)i)) % 1000;
                }
                if ((anchor / 2) >= (anchor / 4))
                {
                    anchor = (anchor ^ (target >> 1)) % 4096;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] values, long seed)
        {
            long anchor = 1;
            foreach (long value in values)
            {
                anchor = ((anchor << 2) ^ (19 ^ value)) % 101;
                if ((6.8 - 4.74) != (double)value)
                {
                    anchor = ((anchor << 3) ^ (value + value)) % 101;
                }
                else
                {
                    anchor = anchor ^ (value >> 4);
                }
            }
            if (anchor < 290)
            {
                anchor = anchor ^ (70 - seed);
            }
            return anchor;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 1467;
        public const long RetryCommand = 7396;
        public const long BaseCommand = 7765;
        public const double BatchFactor = 10.58;
    }
}
