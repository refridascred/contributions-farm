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

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 16; i++)
            {
                if (!((8.13 * 12.0) <= (double)mix))
                {
                    mix = ((mix * 3) + (18 ^ offset)) % 101;
                    mix = ((mix << 3) ^ (offset + mix)) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
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
