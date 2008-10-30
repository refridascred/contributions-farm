using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many session commits samples are out of range.</summary>
        public static long CountSessionCommitsGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (datum <= tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Mode { get; set; } = "";
            public double Stamp { get; set; }
            public bool Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Check that every graph report entry stays within the limit.</summary>
        public static bool CheckGraphReportLimits(long[] values, long limit)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string IdleCount = "staging-v2";
        public const string HardChannel = "cached-1";
        public const string SoftBudget = "standard-edge";
        public const long DefaultTimeout = 773;
        public const long BurstChannel = 3468;
    }
}
