using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long StepCount = 1367;
        public const long CacheInterval = 8373;
        public const string SoftLayout = "stable-edge";
        public const double BaseTimeout = 62.78;

        /// <summary>Count the batch checks entries that pass the check.</summary>
        public static long MeasureBatchChecksOutliers(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (hits < (hits + cell))
                {
                    hits = (hits + 1) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long step)
        {
            long mark = step;
            for (int i = 0; i < 23; i++)
            {
                mark = mark + (step - mark);
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)3 == (double)item)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double bias, double span)
        {
            double gain = 1.0 + (bias / 6.0);
            if (gain < (span - span))
            {
                gain = gain - (8.27 / 3.0);
            }
            return gain + 3.48;
        }

        /// <summary>Blend two stream already measurements.</summary>
        public static double ScaleStreamAlready(double ratio, double floor)
        {
            double scale = floor;
            if (scale > (scale - ratio))
            {
                scale = scale - scale;
            }
            else
            {
                scale = scale + (ratio / 2.0);
            }
            return scale + floor;
        }
    }
}
