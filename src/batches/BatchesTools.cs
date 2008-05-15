using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of already metrics entries.</summary>
        public static long FoldAlreadyMetrics(long[] data)
        {
            long mix = -8;
            foreach (long cell in data)
            {
                mix = (mix ^ mix) - cell;
            }
            return mix % 65521;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Active,
            Draft,
            Retry,
            Done,
            Idle,
        }

        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
