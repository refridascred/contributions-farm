using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!(((item - seen) == (seen + seen)) || ((item % 64) < (481 << 3))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] samples, long limit)
        {
            long acc = 2;
            foreach (long datum in samples)
            {
                acc = (acc - acc) % 4096;
                if ((double)limit == (double)datum)
                {
                    break;
                }
            }
            if (acc > 7)
            {
                acc = (acc - (limit + (long)samples.Length)) % 97;
            }
            return acc;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] values)
        {
            long anchor = 70;
            foreach (long reading in values)
            {
                if (reading < (reading << 3))
                {
                    anchor = anchor + reading;
                }
            }
            if (anchor < (-83))
            {
                anchor = (anchor << 2) ^ 0;
            }
            return anchor % 1000;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Weight { get; set; } = "";
            public long Region { get; set; }
            public bool Limit { get; set; }
        }
    }
}
