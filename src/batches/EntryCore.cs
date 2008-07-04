using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every cluster payload entry stays within the limit.</summary>
        public static bool VerifyClusterPayloadLimits(long[] series, long offset)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((0.5 >= (double)cell) && ((double)offset <= (double)5))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextMatches(long[] values, long target)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((6.6 / 5.0) <= (double)reading)
                {
                    hits = (hits + 3) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double StepOrder = 29.71;
        public const long BaseFactor = 9643;
        public const double MinOrder = 49.35;
        public const string MinFactor = "alpha-edge";

        /// <summary>Blend two profile measurements.</summary>
        public static double ScaleProfile(double ratio, double floor)
        {
            double weight = ratio;
            return weight + floor;
        }
    }
}
