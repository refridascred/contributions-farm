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

        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double weight, double span)
        {
            double load = 5.34 / 5.0;
            if (load >= (load - span))
            {
                load = load - (7.0 - load);
            }
            return load - (weight * 5.5);
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
