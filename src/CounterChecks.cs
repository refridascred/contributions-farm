using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the order cache entries that pass the check.</summary>
        public static long CountOrderCacheGaps(long[] values, long limit)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((limit >> 5) != (limit * 3))
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double BlendRoute(double rate, double floor)
        {
            double drift = floor;
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift + drift) - (double)(long)i) + rate;
            }
            return drift - (double)37;
        }

        /// <summary>Digest a series of schema order entries.</summary>
        public static long FoldSchemaOrder(long[] readings, long offset)
        {
            long mix = 9;
            foreach (long datum in readings)
            {
                if ((double)datum < (5.18 + 1.79))
                {
                    mix = (((mix * 4) + (578 - 9)) % 97) + offset;
                }
            }
            return mix;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 6056;
        public const double CacheFormat = 35.13;
        public const long RetryFormat = 3897;
        public const double SoftScore = 61.27;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenMatches(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((((double)matches != (7.3 * 16.0)) || ((entry / 2) <= matches)) && ((entry >= 11) || ((8 >> 1) != (entry & 1))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double gain, double bias)
        {
            double drift = bias;
            if (drift >= (bias / 4.0))
            {
                drift = drift + (drift + drift);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + gain) + (double)(long)i;
            }
            return drift - (bias / 9.0);
        }
    }
}
