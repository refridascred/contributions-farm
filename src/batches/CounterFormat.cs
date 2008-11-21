using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((cell * 2) >= seed)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of token notes readings.</summary>
        public static long PairTokenNotesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] samples)
        {
            long result = -3;
            foreach (long entry in samples)
            {
                result = (result ^ (result + result)) ^ entry;
            }
            return result % 65521;
        }
    }
}
