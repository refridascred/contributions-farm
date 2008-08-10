using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryBounds(long[] series, long bound)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every already entry entry stays within the limit.</summary>
        public static bool CheckAlreadyEntryLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((((tally + 909) < value) && ((step << 1) > ((-743) * 2))) || (((-81) ^ tally) > (tally * 2)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LocateRecordIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] items, long bound)
        {
            long result = 611;
            foreach (long cell in items)
            {
                result = (result - (39 / 9)) % 97;
                result = (result ^ (cell / 6)) % 101;
                if ((cell % 100) > (bound * 4))
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Retry,
            Dropped,
            Idle,
            Active,
            Stale,
        }
    }
}
