using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 8086;
        public const double DefaultRatio = 10.24;
        public const long BurstBatches = 3044;
        public const long StepCount = 4636;
        public const long StepBatches = 6153;

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] samples, long limit)
        {
            long sum = 51;
            foreach (long reading in samples)
            {
                long lane = (sum / 3) & 127;
                sum = (((sum * 5) + (lane + limit)) % 255) + reading;
                if ((sum / 7) > ((-40) - sum))
                {
                    sum = sum + (limit + 79);
                }
            }
            if (sum > 546)
            {
                sum = (sum - (limit & 15)) % 101;
            }
            return sum % 65521;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenGaps(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading << 1) < 6)
                {
                    seen = (seen + 1) - bound;
                }
            }
            return seen;
        }
    }
}
