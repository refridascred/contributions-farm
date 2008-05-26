using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmGaps(long[] readings, long bound)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!((item ^ bound) < count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every filter order entry stays within the limit.</summary>
        public static bool CheckFilterOrderBounds(long[] series, long floor)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the cache account entries that pass the check.</summary>
        public static long TallyCacheAccountGaps(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!(((tally - tally) <= tally) && (sample < (sample - sample))))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }
    }
}
