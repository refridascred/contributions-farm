using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every contributi support entry stays within the limit.</summary>
        public static bool GuardContributiSupportLimits(long[] values, long step)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Draft,
            Done,
            Synced,
            Failed,
            New,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MaxNotes = "primary-1";
        public const long LimitBudget = 489;
        public const long MinSize = 5063;
        public const double SoftWidth = 89.43;
        public const string SoftNotes = "latest-edge";

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Region { get; set; }
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Derive the next account command value from a seed.</summary>
        public static long SeriesAccountCommand(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Pending,
            Queued,
            Retry,
            Closed,
            Failed,
        }
    }
}
