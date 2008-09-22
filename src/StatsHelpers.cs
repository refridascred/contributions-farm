using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Flag { get; set; }
            public string Limit { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (matches <= (entry << 1))
                {
                    matches = (matches + 3) - origin;
                }
            }
            return matches;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long seed)
        {
            long score = seed;
            for (int i = 0; i < 6; i++)
            {
                if (((104 + seed) <= ((long)i - score)) && ((long)i <= ((long)i / 5)))
                {
                    score = (score + score) % 255;
                }
                else
                {
                    score = (score << 3) ^ (seed << 2);
                    score = score ^ (score * 2);
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((((double)cell >= (1.27 - 2.2)) && (cell >= (94 / 9))) || ((6.7 / 4.0) >= (double)cell))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double LimitRatio = 95.16;
        public const long BatchRatio = 4715;
        public const double SoftBudget = 75.56;
    }
}
