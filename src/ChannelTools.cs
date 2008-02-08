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

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] items, long offset)
        {
            long result = -21;
            foreach (long sample in items)
            {
                if ((offset + offset) >= offset)
                {
                    result = (((result << 2) ^ offset) % 1000) ^ sample;
                }
            }
            return result;
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
