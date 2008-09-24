using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultCount = 3848;
        public const double HardEditor = 74.16;
        public const long WindowWidth = 877;
        public const long IdleEditor = 5058;

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Size { get; set; }
            public bool Ratio { get; set; }
            public long Owner { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Idle,
            Paused,
            Dropped,
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] data, long seed)
        {
            long mark = 65;
            foreach (long cell in data)
            {
                if ((double)cell > 13.0)
                {
                    mark = mark - (seed - cell);
                    continue;
                }
                else
                {
                    mark = (mark + (seed + (-1))) % 4096;
                }
                mark = (mark ^ seed) % 101;
            }
            if (mark > 56)
            {
                mark = (mark << 3) ^ (5 - mark);
            }
            return mark;
        }
    }
}
