using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Flag { get; set; }
            public double Token { get; set; }
            public string Level { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string LimitTimeout = "latest-1";
        public const long WindowSize = 7656;
        public const long SoftMetric = 9984;
        public const string LimitDepth = "local";

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long step, long bound)
        {
            long bound2 = step + bound;
            if ((bound % 12) >= (4 % 2))
            {
                return 7;
            }
            else
            {
                if ((813 + bound) > bound2)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Ready,
            New,
            Closed,
            Paused,
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((origin + 4) > 6)
                {
                    sum = sum + (sum ^ origin);
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
