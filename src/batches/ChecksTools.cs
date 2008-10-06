using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountGaps(long[] levels, long step)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((((step + sample) == (sample >> 1)) || ((-592) > step)) && ((double)sample >= 3.5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Paused,
            Active,
            Closed,
            Failed,
            Locked,
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Score { get; set; }
            public bool Token { get; set; }
            public long Count { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Project the next profile checks value.</summary>
        public static double ProjectProfileChecks(double rate, double floor)
        {
            double rate2 = (rate - rate) - (double)81;
            for (int i = 0; i < 7; i++)
            {
                rate2 = ((rate2 + (rate - rate)) + (double)(long)i) - floor;
            }
            return rate2 + (rate2 + 1.5);
        }
    }
}
