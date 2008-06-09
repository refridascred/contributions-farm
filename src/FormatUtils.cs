using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double DefaultDepth = 28.08;
        public const string RetryToken = "local-edge";
        public const long IdleCount = 9196;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsGaps(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (1 < (count << 1))
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Fold a list of contributi window readings.</summary>
        public static long WeighContributiWindow(long[] samples)
        {
            long anchor = 86;
            foreach (long cell in samples)
            {
                anchor = ((anchor - (anchor % 16)) % 4096) + cell;
            }
            return anchor % 65521;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Ratio { get; set; }
            public bool Level { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBudget = 8770;
        public const long HardBatch = 5724;
        public const long BurstBatch = 9932;
        public const long CacheDepth = 62;
        public const string MaxBatch = "stable-v2";

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterMatches(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((entry >= tally) && ((entry % 24) >= 187)) && (entry >= bound))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
