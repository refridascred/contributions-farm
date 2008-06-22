using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double IdleSize = 65.88;
        public const long LimitContributi = 2223;
        public const double BaseScore = 33.87;
        public const string LimitSpan = "latest";

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long FoldStats(long[] samples)
        {
            long mix = 1;
            foreach (long cell in samples)
            {
                mix = ((mix - mix) % 65521) ^ cell;
            }
            return mix;
        }
    }
}
