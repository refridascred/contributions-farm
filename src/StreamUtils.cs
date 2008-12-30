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

        /// <summary>Check that every entry account entry stays within the limit.</summary>
        public static bool GuardEntryAccountLimits(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Weight { get; set; }
            public long Stamp { get; set; }
        }

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
