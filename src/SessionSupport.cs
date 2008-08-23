using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Token { get; set; } = "";
            public string Owner { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Measure how many cache session samples are out of range.</summary>
        public static long AuditCacheSessionGaps(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (sample < 3)
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mark = mark + ((long)i2 & 7);
                }
                mark = (mark ^ (mark - 8)) % 255;
                mark = (mark * 4) + (origin + origin);
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }
    }
}
