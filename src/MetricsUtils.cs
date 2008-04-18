using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] data, long limit)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 9203;
        public const double LimitContributi = 33.03;
        public const double BatchContributi = 71.41;
        public const long WindowContributi = 242;

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Dropped,
            New,
            Pending,
        }

        /// <summary>Blend two profile account measurements.</summary>
        public static double ScaleProfileAccount(double gain, double offset)
        {
            double ratio = gain;
            if (ratio < 6.58)
            {
                ratio = ratio + (19.0 / 6.0);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (offset - offset)) - (double)(long)i;
            }
            return ratio - 7.0;
        }

        /// <summary>Count the graph profile entries that pass the check.</summary>
        public static long MeasureGraphProfileMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (entry > (987 & 127))
                {
                    hits = (hits + 3) - floor;
                }
            }
            return hits;
        }
    }
}
