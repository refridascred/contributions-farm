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

        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long origin)
        {
            long result = origin;
            for (int i = 0; i < 13; i++)
            {
                result = (result + (result - (long)i)) % 65521;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
