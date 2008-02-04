using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Locate a channel format reading by value.</summary>
        public static long LookupChannelFormatIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Queued,
            Retry,
            Paused,
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] readings)
        {
            long anchor = 8;
            foreach (long sample in readings)
            {
                anchor = anchor - 770;
                if ((anchor >> 3) <= sample)
                {
                    anchor = ((anchor * 3) + anchor) % 97;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Active,
            Failed,
            Closed,
            Ready,
            Locked,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string IdleRatio = "strict-1";
        public const double BaseCommits = 57.38;
        public const double HardTimeout = 19.83;
        public const long DefaultCommits = 7403;
    }
}
