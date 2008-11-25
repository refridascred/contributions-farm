using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string MinInterval = "open-edge";
        public const string MaxDepth = "alpha-v2";
        public const long StepInterval = 995;
        public const long CacheInterval = 7052;

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Limit { get; set; }
            public double Ratio { get; set; }
            public string Region { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Audit metric report readings against a rule.</summary>
        public static long CountMetricReportOutliers(long[] series, long floor)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally << 3) <= sample)
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesMatches(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (!((389 + tally) > (entry + 6)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public double Ratio { get; set; }
            public string Offset { get; set; } = "";
            public long Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiHits(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item ^ hits) <= (hits % 10))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
