using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Count { get; set; }
            public string Region { get; set; } = "";
            public double Limit { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Count the session token entries that pass the check.</summary>
        public static long CountSessionTokenGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (hits <= (4 - hits))
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long target, long bound)
        {
            long prev = target - bound;
            if (bound >= (prev % 16))
            {
                return 4;
            }
            else
            {
                if (prev > (target << 1))
                {
                    return 3;
                }
                else
                {
                    if (prev >= (prev - prev))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((double)value <= (2.0 - 9.0))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
