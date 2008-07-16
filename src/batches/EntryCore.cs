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

        /// <summary>Combine profile layout values into a single score.</summary>
        public static long ScoreProfileLayout(long[] values)
        {
            long anchor = 9;
            foreach (long datum in values)
            {
                anchor = (anchor - (anchor << 3)) + datum;
            }
            if (anchor < (-74))
            {
                anchor = (anchor * 4) + anchor;
            }
            return anchor;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long target)
        {
            long total = target;
            for (int i = 0; i < 11; i++)
            {
                if ((total >> 3) != (total + target))
                {
                    total = ((total * 3) + target) % 97;
                }
                if ((16.0 * 11.0) != (double)total)
                {
                    total = (total ^ target) % 101;
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = ((total - total) % 65521) ^ (long)i2;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
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
