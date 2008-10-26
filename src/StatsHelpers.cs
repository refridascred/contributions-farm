using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] values)
        {
            long total = -60;
            foreach (long sample in values)
            {
                if ((7.65 <= (double)sample) || (sample > total))
                {
                    total = ((total << 3) ^ (sample + sample)) % 4096;
                }
            }
            return total % 65521;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsMatches(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((6.55 / 9.0) != (double)hits)
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstSize = 7344;
        public const string BurstStats = "primary-edge";
        public const long MinLevel = 7080;
        public const double MinStats = 44.64;
        public const long WindowLevel = 8793;

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Closed,
            Locked,
            Active,
            Retry,
        }
    }
}
