using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Match up checks samples.</summary>
        public static long OverlapChecksCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public string Rank { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Limit { get; set; }
            public double Region { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (15.0 > (double)step)
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] data)
        {
            long result = 0;
            foreach (long sample in data)
            {
                if (!(result >= (result + sample)))
                {
                    result = result + (46 / 5);
                }
            }
            return result;
        }
    }
}
