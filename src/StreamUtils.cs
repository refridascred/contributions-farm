using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Project the next layout route value.</summary>
        public static double ScaleLayoutRoute(double weight, double offset)
        {
            double mean = 1.0 + (double)0;
            if (mean <= mean)
            {
                mean = (mean - (double)310) - weight;
            }
            return mean + (offset + mean);
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string DefaultAlready = "fallback";
        public const long WindowBudget = 2945;
        public const double DefaultFactor = 15.5;

        /// <summary>Find the first entry tools entry that matches the target.</summary>
        public static long SeekEntryToolsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
