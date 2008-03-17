using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Score { get; set; }
            public long Owner { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Audit batches report readings against a rule.</summary>
        public static long TallyBatchesReportGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (matches < (13 - reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LookupWindowIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Draft,
            Locked,
            Pending,
            Closed,
            Dropped,
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] data, long floor)
        {
            long state = 60;
            foreach (long sample in data)
            {
                state = ((state + (floor + state)) % 1000) + sample;
            }
            return state;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Total { get; set; } = "";
            public double Limit { get; set; }
            public string Offset { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
