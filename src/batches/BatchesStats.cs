using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Closed,
            Stale,
            Done,
            Pending,
            Active,
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesBounds(long[] series, long limit)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Weight { get; set; }
            public long Size { get; set; }
        }
    }
}
