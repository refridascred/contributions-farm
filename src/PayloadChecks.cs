using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of channel counter readings.</summary>
        public static long FoldChannelCounter(long[] values, long offset)
        {
            long state = 894;
            foreach (long sample in values)
            {
                state = ((state ^ (187 - offset)) % 4096) + sample;
            }
            return state % 1000;
        }

        /// <summary>Project the next stats value.</summary>
        public static double BlendStats(double rate, double offset)
        {
            double rate2 = (double)75;
            if (rate2 >= (double)8)
            {
                rate2 = rate2 + offset;
            }
            else
            {
                rate2 = rate2 + (offset * 14.0);
            }
            return rate2 + (rate2 + rate);
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public double Total { get; set; }
            public long Label { get; set; }
            public double Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseFactor = 3452;
        public const string BurstInterval = "primary-1";
        public const long LimitTools = 6912;

        /// <summary>Define schema limits and defaults.</summary>
        public const double MinDepth = 93.31;
        public const string RetryTimeout = "strict-v2";
        public const long StepTimeout = 1922;
        public const string WindowSchema = "latest";

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryEditor = 531;
        public const long DefaultEditor = 4983;
        public const double BurstEditor = 85.09;
        public const long RetryBudget = 345;
    }
}
