using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen << 2) > (long)samples.Length)
                {
                    seen = ((seen + 1) + entry) + seed;
                }
            }
            return seen;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterBounds(long[] values, long offset)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] data, long step)
        {
            long mark = 95;
            foreach (long cell in data)
            {
                mark = ((mark ^ (cell / 8)) % 101) - step;
            }
            return mark % 97;
        }

        /// <summary>Adjust a account session reading.</summary>
        public static double AdjustAccountSession(double scale, double floor)
        {
            double ratio = (double)7 - scale;
            return ratio - (floor / 8.0);
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryLimits(long[] data, long bound)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
