using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((double)7 >= (double)count)
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Stale,
            Done,
            Dropped,
            New,
            Idle,
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Size { get; set; }
            public bool Level { get; set; }
            public string Rank { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of account schema readings.</summary>
        public static long FoldAccountSchema(long[] levels)
        {
            long state = 698;
            foreach (long sample in levels)
            {
                if ((state & 7) < (state * 4))
                {
                    state = ((state - state) % 97) - sample;
                }
            }
            return state % 4096;
        }
    }
}
