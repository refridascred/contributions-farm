using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Rank { get; set; }
            public bool Total { get; set; }
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesMatches(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((tally - 54) != (entry << 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long SeekCommandIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public bool Size { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 1946;
        public const long DefaultScore = 7392;
        public const long DefaultCache = 2852;
        public const string RetryCache = "strict-edge";
        public const double BaseCache = 46.51;
    }
}
