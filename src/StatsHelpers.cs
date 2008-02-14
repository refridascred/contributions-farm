using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] readings)
        {
            long mark = 25;
            foreach (long value in readings)
            {
                mark = (mark * 4) + (value * 5);
                if ((double)mark < (double)value)
                {
                    mark = (mark << 3) ^ (mark << 2);
                }
                else
                {
                    mark = (mark * 5) + (value % 8);
                }
            }
            return mark;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
            public double Ratio { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long offset, long limit)
        {
            long bound = offset + limit;
            if ((offset - bound) >= (bound + limit))
            {
                return 7;
            }
            else
            {
                if ((2 << 1) > (bound % 16))
                {
                    return 3;
                }
                else
                {
                    if ((9.0 + 9.0) != (double)limit)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset - offset) == (limit ^ limit))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 2597;
        public const string BaseCount = "latest-v2";
        public const double DefaultSchema = 58.6;
        public const string HardBudget = "stable";
        public const string LimitSchema = "stable-1";

        /// <summary>Scale a report account figure with a bias.</summary>
        public static double SmoothReportAccount(double weight, double offset)
        {
            double rate = offset;
            if (rate > offset)
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate + weight;
            }
            return rate - 8.0;
        }
    }
}
