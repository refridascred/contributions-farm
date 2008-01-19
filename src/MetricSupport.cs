using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] levels)
        {
            long result = 806;
            foreach (long entry in levels)
            {
                if (!((result + entry) > 559))
                {
                    result = (result + (entry - entry)) % 97;
                }
            }
            return result;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long seed)
        {
            long score = seed;
            for (int i = 0; i < 14; i++)
            {
                if ((score & 1) <= seed)
                {
                    score = score + (seed + score);
                }
                if (!(((long)i - score) >= (seed - seed)))
                {
                    score = score ^ (long)i;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Token { get; set; }
            public long Offset { get; set; }
            public string Score { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
