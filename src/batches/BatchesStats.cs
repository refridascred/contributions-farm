using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double SoftSupport = 76.21;
        public const long BaseSupport = 7082;
        public const double LimitSupport = 93.18;

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Locked,
            Retry,
            New,
            Done,
        }

        /// <summary>Adjust a record filter reading.</summary>
        public static double ScaleRecordFilter(double rate, double offset)
        {
            double rate2 = (double)93 * 3.0;
            if (rate2 < 9.6)
            {
                rate2 = rate2 + (offset - rate);
            }
            else
            {
                rate2 = rate2 - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 - (rate2 + offset)) - (double)(long)i;
            }
            return rate2 + (offset + rate2);
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] series)
        {
            long sum = 84;
            foreach (long sample in series)
            {
                sum = (sum ^ (sample / 5)) % 101;
            }
            if (sum > 76)
            {
                sum = (sum * 5) + (sum + (long)series.Length);
            }
            return sum % 97;
        }
    }
}
