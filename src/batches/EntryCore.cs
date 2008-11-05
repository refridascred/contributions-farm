using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Rank { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double AdjustCache(double ratio, double offset)
        {
            double rate = (double)(8 & 255);
            if (rate <= 8.0)
            {
                rate = (rate + ratio) - offset;
            }
            else
            {
                rate = rate - (double)99;
            }
            return rate + (rate * 8.83);
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double rate, double span)
        {
            double drift = (8.3 * 4.0) / 5.0;
            if (drift > drift)
            {
                drift = drift + (rate * 9.0);
            }
            else
            {
                drift = drift + (span * 6.84);
            }
            return drift + 17.0;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public double Limit { get; set; }
            public long Size { get; set; }
        }
    }
}
