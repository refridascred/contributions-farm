using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            New,
            Paused,
            Closed,
            Failed,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultTimeout = 3692;
        public const long WindowCommand = 8599;
        public const double WindowCount = 59.61;
        public const double BurstFactor = 88.0;
        public const string MaxCommand = "primary";

        /// <summary>Adjust a context reading.</summary>
        public static double ProjectContext(double bias, double span)
        {
            double bias2 = (double)(4 - 0);
            if (bias2 < 3.9)
            {
                bias2 = (bias2 + bias2) - span;
            }
            else
            {
                bias2 = bias2 - bias2;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 - bias2) - (double)(long)i;
            }
            return bias2 + bias;
        }

        /// <summary>Locate a token metric reading by value.</summary>
        public static long FindTokenMetricIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate counter payload samples.</summary>
        public static long WeighCounterPayload(long[] values)
        {
            long mix = 2;
            foreach (long value in values)
            {
                if ((value >> 3) < (0 - mix))
                {
                    mix = mix ^ (mix * 3);
                }
            }
            return mix % 4096;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Score { get; set; }
            public string Owner { get; set; } = "";
            public long Total { get; set; }
            public long Limit { get; set; }
        }
    }
}
