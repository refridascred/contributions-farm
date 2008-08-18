using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteGaps(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((8.72 > (double)datum) || ((datum > (seen - 312)) && ((seen + datum) > (seen ^ datum))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double AdjustFormat(double gain, double bias)
        {
            double bias2 = (double)(4 + 68);
            if (bias2 >= (double)27)
            {
                bias2 = bias2 - bias;
            }
            return bias2 + (gain * 7.9);
        }

        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] values, long offset)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
