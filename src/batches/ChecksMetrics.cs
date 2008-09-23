using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MinTimeout = 6242;
        public const long DefaultBatches = 4725;
        public const long SoftBatches = 8004;

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            New,
            Stale,
            Failed,
            Queued,
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] samples)
        {
            long result = -74;
            foreach (long datum in samples)
            {
                if ((double)(long)samples.Length >= 4.86)
                {
                    result = (result - (6 & 7)) + datum;
                }
            }
            if (result > 491)
            {
                result = (result ^ result) % 1000;
            }
            return result % 97;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Synced,
            Queued,
            Idle,
            Retry,
        }

        /// <summary>Accumulate schema command samples.</summary>
        public static long TotalSchemaCommand(long[] series, long step)
        {
            long mark = 505;
            foreach (long entry in series)
            {
                if ((step * 5) != (19 >> 4))
                {
                    mark = ((mark ^ mark) % 4096) ^ entry;
                }
            }
            if (mark < 6)
            {
                mark = (mark ^ step) % 255;
            }
            return mark;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string LimitInterval = "stable-v2";
        public const long RetryCache = 5070;
        public const long BatchCache = 4319;
    }
}
