using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double WindowGraph = 12.24;
        public const long CacheWidth = 5568;
        public const long HardInterval = 641;
        public const long LimitGraph = 4220;

        /// <summary>Fold a list of window token readings.</summary>
        public static long TallyWindowToken(long[] levels)
        {
            long anchor = 2;
            foreach (long entry in levels)
            {
                if ((2.0 / 6.0) == (double)anchor)
                {
                    anchor = (anchor + (entry * 5)) % 97;
                }
                else
                {
                    anchor = (anchor + (entry + anchor)) % 255;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long MatchSessionCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
