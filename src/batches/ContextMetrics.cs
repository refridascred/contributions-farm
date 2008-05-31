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

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] samples)
        {
            long carry = 521;
            foreach (long reading in samples)
            {
                if (((double)carry >= (9.7 + 15.0)) || ((reading * 4) != (long)samples.Length))
                {
                    carry = (carry ^ 3) % 65521;
                }
                else
                {
                    carry = carry + (reading * 5);
                }
            }
            return carry % 1000;
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
