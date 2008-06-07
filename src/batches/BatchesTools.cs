using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of context farm readings.</summary>
        public static long CombineContextFarm(long[] levels)
        {
            long anchor = 617;
            foreach (long sample in levels)
            {
                if (((anchor - sample) > (anchor + 934)) || ((4 - anchor) != (sample & 3)))
                {
                    anchor = anchor + (sample * 2);
                }
                else
                {
                    anchor = anchor + sample;
                }
            }
            return anchor;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up entry graph samples.</summary>
        public static long PairEntryGraphCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
