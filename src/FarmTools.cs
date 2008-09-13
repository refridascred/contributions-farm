using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricHits(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)(-6) < (double)datum)
                {
                    seen = (seen + 3) - offset;
                }
            }
            return seen;
        }

        /// <summary>Validate order farm readings against a bound.</summary>
        public static bool CheckOrderFarmBounds(long[] items, long bound)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((count - entry) >= count) || !((count + (long)series.Length) != (count * 4)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
