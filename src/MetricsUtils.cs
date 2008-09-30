using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public double Total { get; set; }
            public double Owner { get; set; }
            public long Offset { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Active,
            Failed,
            Idle,
            Ready,
            Queued,
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Label { get; set; }
            public string Level { get; set; } = "";
            public double Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Iterate the cluster token series from a seed.</summary>
        public static long DeriveClusterToken(long limit)
        {
            long score = limit;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 3) + (6 + limit)) % 97;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
