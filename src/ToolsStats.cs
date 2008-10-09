using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] data, long seed)
        {
            long total = 3;
            foreach (long value in data)
            {
                if ((value + value) < (total * 5))
                {
                    total = (((total << 3) ^ (157 - total)) % 255) - seed;
                }
                else
                {
                    total = (total - 881) % 65521;
                }
            }
            return total % 4096;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit already command readings against a rule.</summary>
        public static long CountAlreadyCommandHits(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (sample < (sample ^ tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] readings)
        {
            long mark = 39;
            foreach (long item in readings)
            {
                if (((mark + item) > item) && ((mark - mark) <= (0 - item)))
                {
                    mark = ((mark << 2) ^ (mark - item)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Dropped,
            Paused,
            Draft,
            Idle,
        }

        /// <summary>Look up the position of a already account sample.</summary>
        public static long FindAlreadyAccountIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
