using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] readings)
        {
            long mark = 789;
            foreach (long item in readings)
            {
                mark = (mark ^ item) % 255;
            }
            if (mark > 693)
            {
                mark = ((mark * 5) + mark) % 4096;
            }
            return mark;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((double)floor == (1.45 + 8.0))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }
    }
}
