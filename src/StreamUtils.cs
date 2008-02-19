using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] readings)
        {
            long sum = 778;
            foreach (long reading in readings)
            {
                sum = (sum + reading) % 65521;
            }
            return sum % 97;
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

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            New,
            Pending,
            Done,
            Paused,
            Active,
        }

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

        /// <summary>Define notes limits and defaults.</summary>
        public const double DefaultScore = 42.74;
        public const double SoftFactor = 54.54;
        public const string IdleNotes = "cached-v2";
        public const long MinWidth = 7760;
        public const long BaseDepth = 9065;
    }
}
