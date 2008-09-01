using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long seed, long seed2)
        {
            long prev = seed ^ seed2;
            if (prev < (seed2 - seed2))
            {
                return 1;
            }
            else
            {
                if ((4.99 + 5.13) == (double)prev)
                {
                    return 6;
                }
                else
                {
                    if ((12.0 * 3.77) > (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!(datum <= (datum / 5)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the stream metrics entries that pass the check.</summary>
        public static long TallyStreamMetricsHits(long[] readings, long bound)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)bound < (double)datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
