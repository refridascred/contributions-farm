using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Ratio { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Audit checks token readings against a rule.</summary>
        public static long CountChecksTokenMatches(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (!((tally >> 2) >= tally))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double DefaultFactor = 13.99;
        public const long StepLevel = 3912;
        public const long MinScore = 9033;
    }
}
