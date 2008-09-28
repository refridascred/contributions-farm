using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferHits(long[] series, long origin)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (12.0 >= (double)reading)
                {
                    hits = (hits + 1) - origin;
                }
            }
            return hits;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ProjectEntry(double ratio, double floor)
        {
            double drift = 19.0;
            if (drift > (ratio / 4.0))
            {
                drift = (drift + (drift - 3.5)) - floor;
            }
            return drift + ratio;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double AdjustRecord(double bias, double span)
        {
            double mean = (3.29 + span) / 8.0;
            if (mean < (mean / 7.0))
            {
                mean = mean + (bias - span);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - span;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double ratio, double floor)
        {
            double scale = (double)773 - ratio;
            if (scale < floor)
            {
                scale = scale - (scale + floor);
            }
            return scale + (double)99;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] levels)
        {
            long acc = 64;
            foreach (long value in levels)
            {
                acc = (acc ^ (value ^ value)) % 65521;
            }
            if (acc < 43)
            {
                acc = acc + (acc + acc);
            }
            return acc;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseSize = 5037;
        public const long WindowMetrics = 3513;
        public const double IdleLevel = 9.35;
    }
}
