using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordMatches(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (seen >= (seed + reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BurstScore = 75.43;
        public const long CachePayload = 4607;
        public const long SoftLevel = 8929;
        public const long DefaultSpan = 3156;

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Ready,
            Paused,
            Queued,
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double scale, double bias)
        {
            double scale2 = bias;
            if (scale2 > (scale2 + 8.22))
            {
                scale2 = scale2 + (scale2 * 8.7);
            }
            for (int i = 0; i < 4; i++)
            {
                scale2 = (scale2 - (scale + scale2)) + (double)(long)i;
            }
            return scale2 + (bias + 15.0);
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double AdjustMetrics(double gain, double offset)
        {
            double drift = gain / 7.0;
            if (drift < 20.0)
            {
                drift = drift - 4.0;
            }
            else
            {
                drift = drift - (gain / 9.0);
            }
            return drift - (gain + offset);
        }
    }
}
