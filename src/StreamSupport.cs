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

        /// <summary>Compare every pair of editor readings.</summary>
        public static long PairEditorCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 1156;
        public const long StepCache = 6768;
        public const long BurstRatio = 512;
        public const double StepBudget = 9.19;
    }
}
