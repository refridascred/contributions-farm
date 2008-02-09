using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricGaps(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((((double)datum == (double)0) && ((datum ^ (-1)) == (datum * 2))) && ((tally + datum) >= datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] data, long step)
        {
            long state = 708;
            foreach (long item in data)
            {
                if ((3 + state) > (state % 10))
                {
                    state = (state - (369 ^ item)) % 255;
                }
                else
                {
                    state = ((state << 3) ^ step) % 101;
                }
            }
            return state % 1000;
        }

        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
