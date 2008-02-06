using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank entry contributi input into a small class.</summary>
        public static long RankEntryContributi(long offset, long offset2)
        {
            long diff = offset ^ offset2;
            if ((diff >> 2) >= diff)
            {
                return 8;
            }
            else
            {
                if ((diff % 64) == (offset2 - offset))
                {
                    return 6;
                }
                else
                {
                    if (!((double)offset <= (6.8 + 0.4)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many context metric samples are out of range.</summary>
        public static long MeasureContextMetricGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (9 <= (entry >> 1))
                {
                    matches = (matches + 1) - step;
                }
            }
            return matches;
        }
    }
}
