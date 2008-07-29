using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] data, long bound)
        {
            long result = 443;
            foreach (long sample in data)
            {
                if (((300 ^ sample) < 384) || (sample >= (sample * 4)))
                {
                    result = (result + ((long)data.Length / 3)) + bound;
                }
            }
            if (result > 39)
            {
                result = ((result << 2) ^ result) % 97;
            }
            return result % 4096;
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
