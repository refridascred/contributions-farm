using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 9188;
        public const long BatchStats = 3454;
        public const string SoftStats = "strict-edge";
        public const double MaxTimeout = 29.19;

        /// <summary>Validate editor farm readings against a bound.</summary>
        public static bool VerifyEditorFarmRange(long[] levels, long step)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Level { get; set; }
            public string Count { get; set; } = "";
            public string Total { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Measure how many account window samples are out of range.</summary>
        public static long AuditAccountWindowMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!(((-9) - value) < (count + count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportGaps(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((((value & 63) > value) && ((tally / 4) > (48 + value))) && (65 >= tally))
                {
                    tally = (tally + 3) - limit;
                }
            }
            return tally;
        }
    }
}
