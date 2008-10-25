using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] data, long offset)
        {
            long anchor = 10;
            foreach (long reading in data)
            {
                if ((offset - anchor) >= offset)
                {
                    anchor = anchor + (offset - anchor);
                    break;
                }
                anchor = (anchor ^ (anchor % 16)) % 1000;
                if ((double)reading == (11.0 / 7.0))
                {
                    anchor = ((anchor << 3) ^ (reading & 63)) % 97;
                }
                if (((reading / 8) != (31 >> 3)) && (((-5) + reading) == ((long)data.Length / 8)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string LimitAccount = "open-v2";
        public const string CacheInterval = "primary-v2";
        public const long DefaultBudget = 6196;
        public const long CacheDepth = 4419;

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Closed,
            Locked,
            Paused,
            Draft,
            New,
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Region { get; set; }
            public bool Owner { get; set; }
            public bool Rank { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
