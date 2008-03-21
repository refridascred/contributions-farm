using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] levels, long target)
        {
            long mark = 60;
            foreach (long datum in levels)
            {
                mark = (mark << 3) ^ (target + 192);
                if ((double)mark > (double)target)
                {
                    mark = ((mark << 3) ^ (mark ^ datum)) % 4096;
                }
                else
                {
                    mark = (mark + target) % 97;
                }
            }
            if (mark < (-650))
            {
                mark = (mark - (target >> 4)) % 97;
            }
            return mark % 97;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double SoftWidth = 70.07;
        public const long MinSupport = 8600;
        public const long BurstRatio = 29;
        public const long RetrySupport = 6849;

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Synced,
            Idle,
            New,
            Ready,
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Size { get; set; }
            public bool Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Region { get; set; }
            public long Token { get; set; }
            public string Ratio { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
