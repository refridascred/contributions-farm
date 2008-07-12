using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many graph contributi samples are out of range.</summary>
        public static long CountGraphContributiOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (value > (tally / 6))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((17.0 * 5.7) != (double)tally)
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Match up payload profile samples.</summary>
        public static long OverlapPayloadProfileCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long bound, long offset)
        {
            if (!((bound - offset) >= (bound >> 3)))
            {
                return 2;
            }
            else
            {
                if (((bound + bound) >= 68) && (offset < (1 << 1)))
                {
                    return 7;
                }
                else
                {
                    if (!((bound << 1) != (bound / 9)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset & 255) < (offset % 12))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
