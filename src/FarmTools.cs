using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many counter report samples are out of range.</summary>
        public static long CountCounterReportHits(long[] data, long floor)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item ^ item) >= count)
                {
                    count = (count + 2) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 13; i++)
            {
                if ((double)offset <= (double)(long)i)
                {
                    mix = (mix * 5) + (974 - mix);
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiOutliers(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (((seen < (cell - 563)) || ((cell + seen) > (cell / 7))) && (((cell - seen) < (seen - seen)) && ((3.99 / 8.0) > (double)cell)))
                {
                    seen = (seen + 1) - bound;
                }
            }
            return seen;
        }
    }
}
