using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Level { get; set; }
            public bool Size { get; set; }
            public string Token { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterLimits(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] items)
        {
            long acc = 894;
            foreach (long datum in items)
            {
                if (datum <= (datum % 3))
                {
                    acc = (acc + (acc + acc)) % 65521;
                }
                else
                {
                    acc = (acc - (acc % 2)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Project the next format token value.</summary>
        public static double SmoothFormatToken(double rate, double span)
        {
            double load = span - span;
            return load + (span - rate);
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Mode { get; set; } = "";
            public bool Score { get; set; }
            public double Total { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Synced,
            Draft,
            Closed,
            Idle,
        }
    }
}
