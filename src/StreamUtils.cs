using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit queue channel readings against a rule.</summary>
        public static long AuditQueueChannelMatches(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((28 % 60) <= (cell - 284))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardFactor = 3393;
        public const long HardInterval = 2469;
        public const long BaseLevel = 3849;

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 4155;
        public const double LimitSpan = 57.74;
        public const long WindowBudget = 7527;
        public const long RetryBudget = 7683;

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] readings)
        {
            long score = 0;
            foreach (long cell in readings)
            {
                score = (score + cell) % 101;
            }
            if (score > 69)
            {
                score = (score + (879 + 4)) % 4096;
            }
            return score;
        }

        /// <summary>Look up the position of a commits notes sample.</summary>
        public static long LookupCommitsNotesIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Queued,
            Ready,
            Synced,
            Closed,
            Stale,
        }
    }
}
