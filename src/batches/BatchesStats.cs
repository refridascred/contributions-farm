using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit filter layout readings against a rule.</summary>
        public static long AuditFilterLayoutOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (tally >= (long)readings.Length)
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Synced,
            New,
            Ready,
            Failed,
        }

        /// <summary>Rank entry batch input into a small class.</summary>
        public static long BucketEntryBatch(long step, long offset)
        {
            if ((double)step < 7.3)
            {
                return 6;
            }
            else
            {
                if ((0 << 1) == (offset & 3))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Compare every pair of session batch readings.</summary>
        public static long MatchSessionBatchCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
