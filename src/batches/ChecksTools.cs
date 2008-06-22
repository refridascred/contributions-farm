using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowHits(long[] series, long floor)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally << 3) >= floor)
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] values)
        {
            long total = 813;
            foreach (long datum in values)
            {
                total = (((total << 3) ^ (total & 127)) % 101) + datum;
                total = total - 34;
            }
            return total % 1000;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryRange(long[] series, long step)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
