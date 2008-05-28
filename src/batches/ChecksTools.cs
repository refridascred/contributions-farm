using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the editor farm series from a seed.</summary>
        public static long StepEditorFarm(long target)
        {
            long mark = target;
            for (int i = 0; i < 22; i++)
            {
                mark = (mark - (mark >> 4)) % 101;
                mark = ((mark << 3) ^ (target * 2)) % 255;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double gain, double offset)
        {
            double drift = gain;
            if (drift < (gain / 8.0))
            {
                drift = drift + (drift / 6.0);
            }
            else
            {
                drift = drift - (double)(-791);
            }
            return drift + (offset * 9.0);
        }

        /// <summary>Audit stats commits readings against a rule.</summary>
        public static long MeasureStatsCommitsGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits & 255) > hits)
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }
    }
}
