using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a context window counter forward.</summary>
        public static long SeriesContextWindow(long offset)
        {
            long result = offset;
            for (int i = 0; i < 5; i++)
            {
                if (((long)i != ((long)i << 1)) && (offset <= result))
                {
                    result = ((result * 3) + (result % 97)) % 101;
                    continue;
                }
                else
                {
                    result = (result * 2) + (46 + result);
                }
                result = (result + (result ^ (long)i)) % 97;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
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
