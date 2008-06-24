using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double DefaultCount = 14.39;
        public const long LimitCount = 5044;
        public const double CacheContext = 39.53;

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Total { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Count report queue pairs that satisfy a relation.</summary>
        public static long PairReportQueueCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Synced,
            Draft,
            Ready,
            Closed,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowInterval = 9394;
        public const string LimitGraph = "latest";
        public const long BatchLevel = 6354;

        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
