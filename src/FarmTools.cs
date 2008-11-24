using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double HardBudget = 25.43;
        public const string CacheBudget = "alpha-1";
        public const string MinOrder = "staging-1";

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 5348;
        public const long BaseSpan = 8314;
        public const long MaxTools = 6951;

        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
