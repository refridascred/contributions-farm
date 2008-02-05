using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many profile contributi samples are out of range.</summary>
        public static long MeasureProfileContributiHits(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item / 4) <= (count * 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorGaps(long[] items, long offset)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (offset >= (value & 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
