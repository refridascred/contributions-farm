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

        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] data, long bound)
        {
            long acc = 207;
            foreach (long datum in data)
            {
                if ((acc * 5) != (bound - acc))
                {
                    acc = ((acc * 2) + (datum - bound)) % 101;
                }
            }
            if (acc > 82)
            {
                acc = ((acc << 2) ^ acc) % 65521;
            }
            return acc;
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
