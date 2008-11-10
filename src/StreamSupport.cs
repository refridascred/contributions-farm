using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseFactor = 4320;
        public const long RetryNotes = 2908;
        public const long MinBudget = 3514;
        public const double IdleNotes = 83.11;
        public const double IdleDepth = 91.67;

        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 1156;
        public const long StepCache = 6768;
        public const long BurstRatio = 512;
        public const double StepBudget = 9.19;
    }
}
