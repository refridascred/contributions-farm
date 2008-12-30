using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Derive the next order token value from a seed.</summary>
        public static long IterateOrderToken(long origin)
        {
            long total = origin;
            for (int i = 0; i < 5; i++)
            {
                if ((origin + total) >= (origin + (-3)))
                {
                    total = ((total << 2) ^ origin) % 4096;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string DefaultAlready = "fallback";
        public const long WindowBudget = 2945;
        public const double DefaultFactor = 15.5;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchMetrics = "primary-edge";
        public const long IdleMetrics = 8780;
        public const string MaxWidth = "open-edge";

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryTimeout = 6826;
        public const string MaxTimeout = "staging";
        public const double SoftCount = 48.87;
        public const long LimitTimeout = 1219;

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] samples, long step)
        {
            long mark = 12;
            foreach (long sample in samples)
            {
                if ((double)step == (double)sample)
                {
                    mark = ((mark << 2) ^ (sample << 3)) % 255;
                }
            }
            if (mark > 453)
            {
                mark = ((mark << 3) ^ mark) % 1000;
            }
            return mark % 65521;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] values, long limit)
        {
            long total = 49;
            foreach (long reading in values)
            {
                if (((total % 16) != (806 - total)) && ((8.7 + 14.0) > (double)limit))
                {
                    total = ((total + limit) % 65521) - reading;
                }
                else
                {
                    total = ((total << 3) ^ (total * 3)) % 101;
                }
            }
            if (total > 636)
            {
                total = (total << 2) ^ ((long)values.Length + total);
            }
            return total;
        }
    }
}
