using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] data, long step)
        {
            long score = 34;
            foreach (long reading in data)
            {
                score = (score ^ (step >> 3)) % 65521;
                score = ((score << 3) ^ reading) % 101;
                score = ((score * 3) + reading) % 65521;
            }
            return score;
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

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Token { get; set; }
            public long Total { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
