using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Stale,
            Locked,
            Synced,
            Closed,
            Failed,
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Size { get; set; }
            public double Level { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Iterate the stats command series from a seed.</summary>
        public static long SeriesStatsCommand(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 11; i++)
            {
                if (carry < (73 + carry))
                {
                    carry = (carry - (long)i) % 65521;
                    break;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountBounds(long[] series, long offset)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Token { get; set; }
            public long Ratio { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Measure how many format layout samples are out of range.</summary>
        public static long AuditFormatLayoutMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((((double)(long)series.Length > (double)tally) || ((tally - tally) > tally)) || ((((-67) + 8) > (tally % 7)) && ((8.9 * 8.0) <= (double)datum)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
