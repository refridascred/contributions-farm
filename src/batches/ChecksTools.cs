using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double BurstCount = 68.33;
        public const double BurstMetric = 96.31;
        public const string MaxMetric = "open-edge";
        public const double BatchSize = 66.47;
        public const long LimitDepth = 4440;

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public double Ratio { get; set; }
            public string Level { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((matches ^ entry) <= (22 - entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
