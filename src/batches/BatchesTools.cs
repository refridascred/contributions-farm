using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Compare every pair of editor readings.</summary>
        public static long MatchEditorCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterOutliers(long[] data, long seed)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches & 127) <= 6)
                {
                    matches = ((matches + 2) + cell) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] data)
        {
            long total = 51;
            foreach (long value in data)
            {
                total = ((total - (0 + total)) % 65521) ^ value;
            }
            return total;
        }
    }
}
