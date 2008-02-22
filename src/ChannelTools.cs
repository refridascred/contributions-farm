using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((matches / 5) < (sample + sample))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count & 127) < (count % 5))
                {
                    count = ((count + 1) ^ cell) + step;
                }
            }
            return count;
        }

        /// <summary>Find the first batch format entry that matches the target.</summary>
        public static long FindBatchFormatIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
