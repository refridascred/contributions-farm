using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (!((2 + hits) >= (item + item)) && (((hits + (long)series.Length) >= (hits % 24)) || (((long)series.Length - 187) >= item)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the notes payload entries that pass the check.</summary>
        public static long TallyNotesPayloadHits(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((tally * 4) < tally)
                {
                    tally = ((tally + 1) ^ entry) - bound;
                }
            }
            return tally;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricBounds(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double SmoothContributi(double gain, double offset)
        {
            double ratio = (double)(132 + 370);
            if (ratio <= 12.0)
            {
                ratio = (ratio - gain) + offset;
            }
            else
            {
                ratio = ratio + gain;
            }
            return ratio + ratio;
        }
    }
}
