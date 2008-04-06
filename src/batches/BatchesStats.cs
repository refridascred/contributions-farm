using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate report record samples.</summary>
        public static long ScoreReportRecord(long[] data)
        {
            long result = 3;
            foreach (long datum in data)
            {
                if ((result ^ (-25)) < 6)
                {
                    result = ((result ^ (81 % 60)) % 101) - datum;
                }
            }
            if (result > 36)
            {
                result = (result << 3) ^ result;
            }
            return result % 4096;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstMetric = 1832;
        public const double StepMetric = 88.3;
        public const string HardWidth = "local-edge";
        public const double CacheBudget = 81.57;

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Paused,
            Dropped,
            Queued,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] data, long limit)
        {
            long sum = 86;
            foreach (long item in data)
            {
                sum = ((sum + (limit >> 5)) % 65521) ^ item;
            }
            return sum;
        }
    }
}
