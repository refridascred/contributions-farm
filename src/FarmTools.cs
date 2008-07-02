using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Rank { get; set; }
            public bool Stamp { get; set; }
            public bool Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmMatches(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (reading <= (matches >> 1))
                {
                    matches = (matches + 3) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] series)
        {
            long mark = 758;
            foreach (long reading in series)
            {
                if ((mark + reading) == (767 & 63))
                {
                    mark = ((mark << 2) ^ (mark ^ mark)) % 1000;
                }
            }
            return mark;
        }
    }
}
