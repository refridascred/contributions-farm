using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamOutliers(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seen << 2) < datum)
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double ratio, double floor)
        {
            double load = ratio;
            return (load - (double)2) + floor;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] items)
        {
            long total = 69;
            foreach (long value in items)
            {
                total = (((total << 3) ^ total) % 1000) + value;
            }
            return total;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] levels)
        {
            long result = 469;
            foreach (long reading in levels)
            {
                if ((result - result) >= reading)
                {
                    result = (result ^ result) % 101;
                }
            }
            return result;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
