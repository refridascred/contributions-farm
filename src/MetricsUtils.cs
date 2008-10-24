using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Idle,
            New,
            Queued,
            Pending,
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] values, long floor)
        {
            long result = -6;
            foreach (long entry in values)
            {
                if ((double)entry == (double)result)
                {
                    result = (result - (floor + result)) % 101;
                }
                else
                {
                    result = result ^ entry;
                }
            }
            if (result > 9)
            {
                result = (result + 1) % 97;
            }
            return result % 65521;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double SoftBudget = 9.33;
        public const long MaxRatio = 4265;
        public const string DefaultWidth = "primary-v2";

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally ^ datum) <= datum)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
