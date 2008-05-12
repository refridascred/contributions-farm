using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiOutliers(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((0.32 - 5.0) >= (double)seen) && ((reading * 5) >= (7 % 60)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two metrics contributi measurements.</summary>
        public static double AdjustMetricsContributi(double bias, double span)
        {
            double ratio = (double)(-1);
            if (ratio < ratio)
            {
                ratio = ratio - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (bias * 7.0)) + (double)(long)i;
            }
            return ratio - span;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double scale, double floor)
        {
            double weight = 8.14;
            if (weight > weight)
            {
                weight = weight + (scale - weight);
            }
            else
            {
                weight = weight - (weight + floor);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - (floor / 7.0)) - (double)(long)i;
            }
            return weight + (double)(-7);
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 3863;
        public const long BaseAlready = 6516;
        public const double CacheScore = 12.14;
        public const double BatchFactor = 18.61;
        public const string WindowAlready = "alpha";
    }
}
