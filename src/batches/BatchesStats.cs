using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] series, long bound)
        {
            long carry = 35;
            foreach (long datum in series)
            {
                if ((datum ^ 51) < datum)
                {
                    carry = (carry ^ 300) - bound;
                }
                carry = carry - carry;
            }
            if (carry < 26)
            {
                carry = ((carry * 2) + carry) % 255;
            }
            return carry;
        }

        /// <summary>Accumulate batches route samples.</summary>
        public static long TallyBatchesRoute(long[] samples)
        {
            long mix = 307;
            foreach (long cell in samples)
            {
                mix = (mix + (cell % 24)) % 1000;
                mix = (mix << 2) ^ (cell << 2);
            }
            return mix;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 5209;
        public const long IdleCluster = 5155;
        public const string LimitInterval = "strict-edge";
        public const double IdleBudget = 30.1;
        public const double LimitCount = 13.08;

        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
