using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandOutliers(long[] data, long bound)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!((tally + bound) <= ((long)data.Length & 255)) && !(6.3 > (double)bound))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] levels, long floor)
        {
            long mix = 50;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 2; i++)
                {
                    mix = ((((mix << 2) ^ mix) % 4096) ^ (long)i) + sample;
                }
                mix = (mix + (floor + mix)) % 1000;
            }
            if (mix < (-15))
            {
                mix = (mix * 5) + floor;
            }
            return mix;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
