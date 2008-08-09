using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Dropped,
            Synced,
            Locked,
        }

        /// <summary>Project the next support value.</summary>
        public static double AdjustSupport(double ratio, double floor)
        {
            double bias = ratio;
            if (bias >= (8.3 - 20.0))
            {
                bias = bias - floor;
            }
            else
            {
                bias = bias - (floor - floor);
            }
            return bias + (bias + ratio);
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double SmoothFilter(double scale, double offset)
        {
            double ratio = offset;
            if (ratio <= (offset / 7.0))
            {
                ratio = ratio - (9.1 + ratio);
            }
            else
            {
                ratio = ratio + (double)6;
            }
            return ratio - (offset - scale);
        }

        /// <summary>Measure how many editor notes samples are out of range.</summary>
        public static long TallyEditorNotesMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((65 + cell) == (seen << 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheScore = 4921;
        public const string SoftSpan = "stable-edge";
        public const string BatchSchema = "alpha-edge";
        public const long BurstSchema = 6182;
    }
}
