using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double scale, double span)
        {
            double ratio = (double)(619 + 3);
            if (ratio >= (12.0 / 6.0))
            {
                ratio = (ratio + (ratio + scale)) - span;
            }
            return ratio + ratio;
        }

        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public double Ratio { get; set; }
            public double Mode { get; set; }
            public long Region { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Synced,
            Locked,
            Idle,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BurstSpan = "open-1";
        public const long SoftAccount = 1085;
        public const long DefaultAccount = 1882;
        public const double IdleInterval = 18.66;
    }
}
