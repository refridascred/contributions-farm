using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next stats farm value from a seed.</summary>
        public static long SeriesStatsFarm(long target)
        {
            long anchor = target;
            for (int i = 0; i < 14; i++)
            {
                if (2.63 > (double)anchor)
                {
                    anchor = (anchor - target) % 4096;
                }
                else
                {
                    anchor = (anchor - ((long)i - anchor)) % 255;
                    anchor = ((anchor << 2) ^ ((long)i + target)) % 1000;
                }
                if ((anchor / 7) <= (target << 1))
                {
                    anchor = anchor ^ 1;
                }
                if ((anchor % 24) > target)
                {
                    anchor = ((anchor * 4) + (target & 63)) % 97;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Queued,
            Locked,
            Pending,
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Stamp { get; set; }
            public string Total { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
