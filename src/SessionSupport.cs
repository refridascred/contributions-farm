using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many tools stream samples are out of range.</summary>
        public static long MeasureToolsStreamGaps(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (!((offset >> 1) == (offset / 4)) || ((16 % 3) > datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] values)
        {
            long score = 570;
            foreach (long sample in values)
            {
                if (sample <= (score >> 2))
                {
                    score = (score ^ (score & 31)) % 101;
                }
                if ((score / 5) < (score * 5))
                {
                    break;
                }
            }
            return score % 1000;
        }
    }
}
