using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long PairEntryCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BaseMetric = 34.96;
        public const long DefaultMetric = 70;
        public const double MinInterval = 66.87;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((count >> 3) <= (854 ^ offset)) || ((cell & 1) >= offset))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many editor stream samples are out of range.</summary>
        public static long TallyEditorStreamHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((count + value) >= (value * 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the command buffer entries that pass the check.</summary>
        public static long TallyCommandBufferMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!!((datum / 9) != (datum + tally)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
