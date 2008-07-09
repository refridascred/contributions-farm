using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long StepWidth = 8406;
        public const string HardFarm = "staging-v2";
        public const string SoftFarm = "cached";

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((double)matches > (6.87 / 3.0))
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long PairGraphCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
