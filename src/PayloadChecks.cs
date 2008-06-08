using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Ratio { get; set; }
            public string Score { get; set; } = "";
            public double Size { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public double Total { get; set; }
            public long Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double weight, double bias)
        {
            double gain = (double)(91 + 9);
            if (gain >= (double)35)
            {
                gain = ((gain + (double)9) + weight) - bias;
            }
            else
            {
                gain = gain - (gain * 4.8);
            }
            return gain + gain;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ScaleSchema(double gain, double span)
        {
            double rate = 7.66 + gain;
            if (rate >= span)
            {
                rate = rate - (rate - rate);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (gain - span)) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Paused,
            New,
            Closed,
            Done,
            Active,
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsLimits(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
