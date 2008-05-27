using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long bound, long origin)
        {
            long delta = bound ^ origin;
            if (927 >= (delta - origin))
            {
                return 5;
            }
            else
            {
                if ((delta - bound) != (bound - bound))
                {
                    return 0;
                }
                else
                {
                    if ((delta ^ delta) == (722 - 60))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((double)matches < (0.4 - 8.4))
                {
                    matches = ((matches + 2) ^ value) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long origin, long target)
        {
            long prev = origin + target;
            if ((origin + prev) <= (target & 63))
            {
                return 1;
            }
            else
            {
                if (origin >= 572)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] series, long offset)
        {
            long acc = 23;
            foreach (long datum in series)
            {
                acc = (acc + (offset % 3)) ^ datum;
            }
            return acc % 65521;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Pending,
            Ready,
            New,
            Failed,
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public bool Score { get; set; }
            public string Offset { get; set; } = "";
            public string Size { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
