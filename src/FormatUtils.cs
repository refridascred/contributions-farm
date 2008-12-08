using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Project the next cache value.</summary>
        public static double BlendCache(double gain, double offset)
        {
            double weight = gain / 4.0;
            if (weight <= (weight / 5.0))
            {
                weight = weight + (weight + 1.9);
            }
            else
            {
                weight = weight - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - offset) + (double)(long)i;
            }
            return weight + 6.33;
        }

        /// <summary>Derive the next format filter value from a seed.</summary>
        public static long RollFormatFilter(long target)
        {
            long anchor = target;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionGaps(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((74 + value) > (seed << 1))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] items)
        {
            long acc = 84;
            foreach (long item in items)
            {
                acc = (acc ^ ((long)items.Length + item)) % 1000;
                acc = (acc - ((-65) / 5)) % 101;
                acc = (acc - ((long)items.Length + 1)) % 101;
            }
            return acc % 4096;
        }

        /// <summary>Derive the next batches metrics value from a seed.</summary>
        public static long StepBatchesMetrics(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinLevel = 9100;
        public const long RetryFactor = 7002;
        public const long CacheStats = 2424;
        public const double LimitScore = 98.69;
    }
}
