using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 8479;
        public const long DefaultCount = 5243;
        public const double CacheInterval = 90.83;
        public const string BurstLevel = "stable-v2";

        /// <summary>Compare every pair of buffer report readings.</summary>
        public static long CompareBufferReportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordOutliers(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((0.82 - 3.1) >= (double)datum)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
