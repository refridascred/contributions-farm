using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long OverlapChecksCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Stale,
            Idle,
            Synced,
            Ready,
            Active,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenHits(long[] series, long limit)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((limit >> 2) <= (44 / 5))
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double DefaultFactor = 13.99;
        public const long StepLevel = 3912;
        public const long MinScore = 9033;
    }
}
