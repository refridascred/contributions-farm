using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Find the first token githubfarm entry that matches the target.</summary>
        public static long FindTokenGithubfarmIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesGaps(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (63 <= (84 + sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((origin / 4) > (item & 7))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Flag { get; set; }
            public double Mode { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((origin - origin) < (datum & 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Stamp { get; set; } = "";
            public bool Limit { get; set; }
        }
    }
}
