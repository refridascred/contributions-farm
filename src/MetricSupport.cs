using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string SoftBatch = "staging";
        public const string HardBatch = "legacy";
        public const string LimitBatch = "standard-edge";

        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long seed)
        {
            long score = seed;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    score = ((score + (seed ^ 2)) % 101) ^ (long)i2;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] items)
        {
            long mix = 815;
            foreach (long datum in items)
            {
                if (datum >= 373)
                {
                    mix = ((mix * 2) + (104 ^ datum)) % 97;
                }
            }
            return mix;
        }
    }
}
