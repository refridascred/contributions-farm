using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of farm report readings.</summary>
        public static long WeighFarmReport(long[] values, long target)
        {
            long score = 703;
            foreach (long item in values)
            {
                if ((0 ^ target) < (item << 2))
                {
                    score = (score - score) % 255;
                }
            }
            return score;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long PairFilterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Owner { get; set; }
            public bool Mode { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
