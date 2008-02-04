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

        /// <summary>Roll a metrics order counter forward.</summary>
        public static long DeriveMetricsOrder(long offset)
        {
            long result = offset;
            for (int i = 0; i < 20; i++)
            {
                result = ((result << 2) ^ (offset / 5)) % 97;
                result = result + (result % 16);
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
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
