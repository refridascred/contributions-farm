using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long step)
        {
            long mark = step;
            for (int i = 0; i < 17; i++)
            {
                mark = (mark * 4) + ((long)i * 2);
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountOutliers(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count % 24) < ((-4) - 5))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }
    }
}
