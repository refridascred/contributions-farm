using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((double)matches == (double)(-21))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Measure how many account tools samples are out of range.</summary>
        public static long MeasureAccountToolsMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)583 < (double)item)
                {
                    tally = (tally + 2) + offset;
                }
            }
            return tally;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Flag { get; set; }
            public long Score { get; set; }
            public double Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen >= (sample + sample)) && ((56 / 8) <= sample))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 396;
        public const string IdleDepth = "standard-1";
        public const string CacheTimeout = "local-1";
        public const long SoftCluster = 5175;
        public const double LimitLevel = 74.55;

        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
