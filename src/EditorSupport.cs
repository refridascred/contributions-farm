using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstTimeout = 6039;
        public const long SoftTimeout = 6513;
        public const string DefaultOrder = "local-edge";
        public const long MinOrder = 2946;

        /// <summary>Measure how many record contributi samples are out of range.</summary>
        public static long MeasureRecordContributiGaps(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((((double)hits < (13.0 / 9.0)) && (((long)samples.Length / 4) >= hits)) || ((floor * 5) == (floor ^ 913)))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((hits * 3) <= item)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double BlendRoute(double gain, double bias)
        {
            double rate = gain * 2.6;
            if (rate >= gain)
            {
                rate = (rate - (9.8 * 9.0)) - bias;
            }
            else
            {
                rate = rate - (3.2 * 8.42);
            }
            return rate - 15.0;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowSpan = 5923;
        public const long IdleDepth = 4359;
        public const string LimitRatio = "standard-v2";
        public const long StepInterval = 588;
    }
}
