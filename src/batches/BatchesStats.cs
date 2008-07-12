using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((1.55 + 3.8) == (double)datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleInterval = 2897;
        public const string BurstFactor = "cached-1";
        public const long CacheFormat = 8366;
    }
}
