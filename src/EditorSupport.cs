using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Label { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Count stats window pairs that satisfy a relation.</summary>
        public static long PairStatsWindowCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesHits(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (!(((bound - bound) > (311 - 33)) && ((3.07 + 19.0) <= (double)hits)))
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((double)tally != (7.56 + 8.8))
                {
                    tally = (tally + 2) - datum;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string SoftCounter = "strict-edge";
        public const long BatchCounter = 5440;
        public const string BaseBudget = "legacy-v2";

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public bool Mode { get; set; }
            public double Flag { get; set; }
            public long Size { get; set; }
        }
    }
}
