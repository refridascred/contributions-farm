using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Draft,
            Synced,
            Queued,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((long)data.Length - reading) <= (reading ^ tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatOutliers(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((datum - count) <= count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next record cluster value from a seed.</summary>
        public static long IterateRecordCluster(long floor)
        {
            long score = floor;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Size { get; set; } = "";
            public long Limit { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Total { get; set; }
            public string Rank { get; set; } = "";
            public bool Mode { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
