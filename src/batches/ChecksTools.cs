using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long bound, long bound2)
        {
            if ((991 + bound) < (bound / 9))
            {
                return 6;
            }
            else
            {
                if ((bound2 * 5) > bound)
                {
                    return 7;
                }
                else
                {
                    if ((double)bound2 > (7.46 / 3.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if (148 <= (344 + bound2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
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
