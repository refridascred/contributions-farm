using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate order metrics samples.</summary>
        public static long TallyOrderMetrics(long[] data)
        {
            long score = 182;
            foreach (long cell in data)
            {
                score = score ^ (score - cell);
            }
            if (score < 7)
            {
                score = (score * 4) + score;
            }
            return score;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] levels)
        {
            long anchor = 7;
            foreach (long entry in levels)
            {
                anchor = (anchor * 3) + (entry & 127);
            }
            if (anchor > 954)
            {
                anchor = (anchor + (anchor & 3)) % 1000;
            }
            return anchor;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetryCount = 7816;
        public const long StepFactor = 8557;
        public const long RetrySupport = 7963;

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Size { get; set; }
            public string Rank { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (((item / 8) < item) || (tally < 495))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Region { get; set; }
            public long Owner { get; set; }
            public long Flag { get; set; }
        }
    }
}
