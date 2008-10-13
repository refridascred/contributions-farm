using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!((double)count <= 9.0))
                {
                    count = (count + 3) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (!((reading + reading) < hits))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double weight, double offset)
        {
            double ratio = (double)(293 + 55);
            return ((ratio + ratio) + weight) + offset;
        }
    }
}
