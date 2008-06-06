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

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountBounds(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryCount = 2314;
        public const string MinTools = "cached-edge";
        public const long MaxFactor = 9819;
    }
}
