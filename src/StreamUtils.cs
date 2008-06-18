using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Draft,
            Failed,
            Retry,
            Closed,
            Paused,
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] samples)
        {
            long total = 641;
            foreach (long sample in samples)
            {
                total = (((total << 2) ^ (total & 127)) % 101) ^ sample;
            }
            if (total > 0)
            {
                total = (total + total) % 101;
            }
            return total % 4096;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Ratio { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] items, long limit)
        {
            long anchor = 9;
            foreach (long datum in items)
            {
                anchor = ((anchor * 4) + anchor) + datum;
            }
            if (anchor < 7)
            {
                anchor = (anchor ^ (limit % 100)) % 4096;
            }
            return anchor % 65521;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Active,
            New,
            Queued,
        }
    }
}
