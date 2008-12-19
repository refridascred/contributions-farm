using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ScaleContributi(double bias, double floor)
        {
            double rate = 7.05;
            if (rate < (double)512)
            {
                rate = (rate + rate) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (4.5 + rate)) - (double)(long)i;
            }
            return rate + floor;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double gain, double span)
        {
            double mean = span;
            if (mean < (mean * 5.65))
            {
                mean = mean - (gain - 3.58);
            }
            else
            {
                mean = mean + (mean + 14.0);
            }
            return mean - mean;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Limit { get; set; }
            public long Score { get; set; }
            public bool Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Retry,
            Active,
            Done,
            Paused,
            Closed,
        }
    }
}
