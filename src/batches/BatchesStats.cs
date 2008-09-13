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

        /// <summary>Audit checks token readings against a rule.</summary>
        public static long CountChecksTokenMatches(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (!((tally >> 2) >= tally))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double DefaultFactor = 13.99;
        public const long StepLevel = 3912;
        public const long MinScore = 9033;
    }
}
