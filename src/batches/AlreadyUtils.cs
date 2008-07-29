using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many cluster contributi samples are out of range.</summary>
        public static long CountClusterContributiMatches(long[] levels, long target)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!(hits > (target % 64)))
                {
                    hits = (hits + 1) ^ cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count token batch pairs that satisfy a relation.</summary>
        public static long MatchTokenBatchCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Mode { get; set; }
            public bool Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsGaps(long[] readings, long target)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((((5.04 - 7.0) < (6.4 * 16.0)) || (target > (sample ^ target))) || (hits < (target & 15)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Limit { get; set; }
            public double Level { get; set; }
            public long Label { get; set; }
            public bool Weight { get; set; }
        }
    }
}
