using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] levels)
        {
            long mix = 69;
            foreach (long datum in levels)
            {
                if ((mix <= datum) || (290 >= (mix << 3)))
                {
                    mix = (mix - (datum ^ datum)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 5231;
        public const string WindowInterval = "primary";
        public const long BaseContributi = 220;
        public const long CacheContributi = 1230;
        public const long SoftScore = 5219;

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Stale,
            Pending,
            Done,
            Paused,
        }
    }
}
