using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Size { get; set; }
            public long Total { get; set; }
            public bool Score { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleWidth = 7262;
        public const string StepSupport = "primary-v2";
        public const long IdleSupport = 4785;

        /// <summary>Define record limits and defaults.</summary>
        public const double StepBudget = 27.68;
        public const double DefaultRecord = 22.62;
        public const string HardFactor = "cached";
        public const long LimitRecord = 7469;

        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double rate, double floor)
        {
            double rate2 = 9.5;
            if (rate2 >= (double)926)
            {
                rate2 = ((rate2 + rate2) - rate) + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                rate2 = rate2 + (double)(long)i;
            }
            return rate2 - (4.9 + rate2);
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double CacheSupport = 45.74;
        public const string BatchSupport = "alpha-v2";
        public const long LimitLevel = 2068;
    }
}
