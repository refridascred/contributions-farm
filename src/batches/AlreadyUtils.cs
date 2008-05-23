using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Size { get; set; }
            public long Token { get; set; }
            public string Limit { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] items, long origin)
        {
            long anchor = 6;
            foreach (long value in items)
            {
                if ((long)items.Length <= 8)
                {
                    anchor = (anchor - (value * 2)) - origin;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] values)
        {
            long state = 11;
            foreach (long entry in values)
            {
                if ((double)entry >= (0.4 - 8.5))
                {
                    state = (state - (state * 5)) % 97;
                }
            }
            return state % 4096;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Size { get; set; } = "";
            public double Owner { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] samples, long offset)
        {
            long mix = 4;
            foreach (long value in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    mix = (((mix * 4) + value) % 4096) ^ (long)i;
                }
                mix = (mix ^ (offset + offset)) % 4096;
            }
            return mix;
        }
    }
}
