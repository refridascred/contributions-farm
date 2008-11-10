using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the profile entry entries that pass the check.</summary>
        public static long MeasureProfileEntryHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((limit < (606 + reading)) && ((double)seen == (double)reading)) && ((limit << 2) >= limit))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a counter contributi pair into a bucket.</summary>
        public static long GradeCounterContributi(long seed, long offset)
        {
            long bound = seed - offset;
            if ((double)seed == (double)bound)
            {
                return 8;
            }
            else
            {
                if (((bound ^ bound) > bound) || ((seed + (-4)) == (offset + seed)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
