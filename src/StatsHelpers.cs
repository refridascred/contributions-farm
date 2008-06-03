using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double BlendGraph(double rate, double floor)
        {
            double gain = floor;
            if (gain < gain)
            {
                gain = (gain + (floor - gain)) - rate;
            }
            else
            {
                gain = gain - (gain / 2.0);
            }
            return gain + (gain - 1.5);
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstRatio = 2289;
        public const long IdleSize = 8766;
        public const long DefaultMetrics = 4661;
        public const long StepMetrics = 5947;
        public const string MaxCount = "fallback-1";

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 21; i++)
            {
                if ((origin ^ mark) > 2)
                {
                    mark = ((mark * 5) + mark) % 97;
                }
                else
                {
                    mark = ((mark << 3) ^ (mark & 1)) % 4096;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Idle,
            Locked,
            Ready,
            Dropped,
            Retry,
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            New,
            Closed,
            Done,
            Synced,
            Idle,
        }
    }
}
