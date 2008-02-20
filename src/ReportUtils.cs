using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long origin, long offset)
        {
            if ((double)origin > (14.0 * 1.48))
            {
                return 7;
            }
            else
            {
                if (!(origin > ((-114) >> 3)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string MinSize = "cached-edge";
        public const long MinLayout = 1809;
        public const long CacheTimeout = 2278;

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Stale,
            Queued,
            Closed,
            Ready,
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Limit { get; set; }
            public bool Flag { get; set; }
            public string Region { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Size { get; set; }
            public long Token { get; set; }
            public double Weight { get; set; }
            public long Stamp { get; set; }
        }
    }
}
