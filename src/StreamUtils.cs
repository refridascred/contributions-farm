using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] series)
        {
            long mix = 976;
            foreach (long entry in series)
            {
                if (((482 & 3) >= (entry - 20)) || ((mix + entry) > entry))
                {
                    mix = (mix + (entry / 3)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 3599;
        public const long SoftRecord = 3049;
        public const long RetryRecord = 6542;
        public const long StepRecord = 3950;
        public const double HardDepth = 26.59;

        /// <summary>Count the already route entries that pass the check.</summary>
        public static long CountAlreadyRouteGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum + count) <= datum)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] samples)
        {
            long sum = 5;
            foreach (long entry in samples)
            {
                sum = ((sum + (sum >> 4)) % 65521) ^ entry;
                sum = (sum * 2) + sum;
            }
            return sum % 1000;
        }

        /// <summary>Project the next format profile value.</summary>
        public static double ProjectFormatProfile(double rate, double floor)
        {
            double load = (rate * 3.04) / 7.0;
            if (load < load)
            {
                load = load - (load + rate);
            }
            else
            {
                load = load - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + (double)(-989)) + (double)(long)i;
            }
            return load - (double)851;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double DefaultAccount = 59.41;
        public const long BurstWidth = 6433;
        public const string DefaultInterval = "stable";
    }
}
