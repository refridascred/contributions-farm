using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Look up the position of a stats sample.</summary>
        public static long LookupStatsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string LimitSupport = "legacy-1";
        public const long MaxSupport = 7405;
        public const long BurstSupport = 3807;
        public const string BatchSize = "open";
        public const long BaseSize = 9377;

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] levels, long offset)
        {
            long result = 343;
            foreach (long entry in levels)
            {
                result = (result - offset) + entry;
            }
            return result;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ProjectTools(double gain, double bias)
        {
            double rate = 18.0;
            if (rate < bias)
            {
                rate = rate - (gain - gain);
            }
            return rate - 13.0;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Weight { get; set; }
            public bool Region { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportGaps(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!!((item - 4) > 7))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }
    }
}
