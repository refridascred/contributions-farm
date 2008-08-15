using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Active,
            Retry,
            Paused,
            Idle,
            Queued,
        }

        /// <summary>Count githubfarm batches pairs that satisfy a relation.</summary>
        public static long PairGithubfarmBatchesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of report batch entries.</summary>
        public static long CombineReportBatch(long[] series)
        {
            long total = 58;
            foreach (long cell in series)
            {
                total = ((total << 3) ^ cell) % 255;
            }
            return total;
        }
    }
}
