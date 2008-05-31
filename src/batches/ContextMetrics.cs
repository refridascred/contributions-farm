using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long SoftWidth = 1230;
        public const string LimitCount = "local-1";
        public const double MinAccount = 88.33;
        public const long LimitFactor = 9094;

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count - count) > (count + sample))
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Idle,
            Draft,
            New,
            Failed,
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] series)
        {
            long carry = 227;
            foreach (long cell in series)
            {
                if (((double)carry != (double)177) && (((-330) << 3) != ((long)series.Length << 1)))
                {
                    carry = (carry ^ (cell * 5)) % 4096;
                }
                carry = (carry ^ (cell ^ carry)) % 4096;
            }
            return carry;
        }

        /// <summary>Blend two batches record measurements.</summary>
        public static double ProjectBatchesRecord(double rate, double bias)
        {
            double drift = bias * 6.5;
            if (drift < bias)
            {
                drift = (drift - drift) - rate;
            }
            else
            {
                drift = drift + (9.18 / 6.0);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (drift * 8.0)) + (double)(long)i;
            }
            return drift + bias;
        }
    }
}
