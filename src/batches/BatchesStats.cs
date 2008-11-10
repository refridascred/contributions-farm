using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long origin)
        {
            long result = origin;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BaseWidth = 50.1;
        public const double LimitLevel = 10.61;
        public const long BatchWindow = 1525;

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Done,
            Paused,
            Retry,
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Retry,
            Draft,
            Queued,
        }
    }
}
