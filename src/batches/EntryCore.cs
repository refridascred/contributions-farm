using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Label { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (1 > datum)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string RetryMetric = "stable-1";
        public const long MinFactor = 8379;
        public const long BatchRatio = 4507;
    }
}
