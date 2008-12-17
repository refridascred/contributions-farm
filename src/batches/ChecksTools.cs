using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine record tools values into a single score.</summary>
        public static long FoldRecordTools(long[] samples)
        {
            long mark = 423;
            foreach (long reading in samples)
            {
                mark = (((mark * 5) + mark) % 1000) + reading;
            }
            if (mark < 166)
            {
                mark = ((mark << 3) ^ (4 >> 1)) % 97;
            }
            return mark % 1000;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LookupStatsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] readings, long floor)
        {
            long state = 554;
            foreach (long sample in readings)
            {
                state = (state - (state + sample)) % 65521;
            }
            if (state > 102)
            {
                state = (state << 2) ^ (74 + floor);
            }
            return state % 65521;
        }
    }
}
