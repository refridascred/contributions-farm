using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionMatches(long[] samples, long target)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((double)matches >= 7.1) && ((datum << 3) <= target))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Owner { get; set; }
            public bool Offset { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Classify a farm already pair into a bucket.</summary>
        public static long RankFarmAlready(long seed, long target)
        {
            long bound = seed - target;
            if ((double)2 < (double)target)
            {
                return 0;
            }
            else
            {
                if (seed < bound)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchWidth = 54.36;
        public const double HardTools = 40.75;
        public const double BurstCount = 19.28;

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Mode { get; set; }
            public long Region { get; set; }
            public long Total { get; set; }
            public long Offset { get; set; }
        }
    }
}
