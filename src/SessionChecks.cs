using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 5705;
        public const long RetryOrder = 7244;
        public const double BurstSpan = 82.57;
        public const long LimitSpan = 5083;

        /// <summary>Adjust a account reading.</summary>
        public static double SmoothAccount(double scale, double floor)
        {
            double ratio = scale;
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (ratio - floor)) - (double)(long)i;
            }
            return ratio + (double)477;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Offset { get; set; }
            public long Score { get; set; }
            public double Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSession = 4246;
        public const long IdleSession = 7512;
        public const long BaseSession = 637;
        public const long WindowSession = 202;
    }
}
