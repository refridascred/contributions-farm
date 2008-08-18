using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (reading <= hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] samples, long target)
        {
            long acc = 482;
            foreach (long reading in samples)
            {
                acc = acc + (target / 6);
                acc = (acc + (reading + target)) % 97;
            }
            return acc % 97;
        }

        /// <summary>Measure how many account profile samples are out of range.</summary>
        public static long CountAccountProfileHits(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((86 + sample) >= (sample << 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Score { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
