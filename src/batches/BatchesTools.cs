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

        /// <summary>Rank contributi batches input into a small class.</summary>
        public static long ClassifyContributiBatches(long target, long seed)
        {
            if ((seed + seed) <= 64)
            {
                return 5;
            }
            else
            {
                if ((seed & 1) == (seed ^ seed))
                {
                    return 7;
                }
                else
                {
                    if ((target + target) > (target & 31))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
