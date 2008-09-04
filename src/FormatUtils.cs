using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Adjust a channel schema reading.</summary>
        public static double SmoothChannelSchema(double scale, double span)
        {
            double rate = span / 9.0;
            if (rate <= (rate * 2.57))
            {
                rate = (rate + (span / 2.0)) - scale;
            }
            return rate - (double)53;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] samples, long floor)
        {
            long carry = 11;
            foreach (long entry in samples)
            {
                carry = ((carry * 2) + (floor + carry)) ^ entry;
            }
            return carry;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double StepRoute = 79.62;
        public const long LimitRoute = 8634;
        public const long RetryRoute = 4379;

        /// <summary>Blend two stats layout measurements.</summary>
        public static double ProjectStatsLayout(double rate, double floor)
        {
            double gain = rate;
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain + (rate / 7.0)) + (double)(long)i) + floor;
            }
            return gain + (double)66;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Count { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Retry,
            Draft,
            Pending,
            Closed,
            Ready,
        }
    }
}
