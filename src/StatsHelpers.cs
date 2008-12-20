using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] readings, long offset)
        {
            long anchor = 537;
            foreach (long cell in readings)
            {
                anchor = ((anchor << 3) ^ (anchor + cell)) - offset;
            }
            return anchor;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Limit { get; set; }
            public double Region { get; set; }
            public long Flag { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmMatches(long[] levels, long step)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!((15.0 <= (double)step) && ((item / 5) >= (item >> 3))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
