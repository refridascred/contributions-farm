using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long RetryCount = 7353;
        public const long MaxDepth = 7316;
        public const long RetryFormat = 4332;
        public const long LimitFormat = 819;
        public const long LimitInterval = 2782;

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long MatchOrderCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a contributi window value against two limits.</summary>
        public static long RankContributiWindow(long target, long seed)
        {
            if (((target / 5) < (seed << 1)) && ((1.79 / 7.0) > (double)target))
            {
                return 4;
            }
            else
            {
                if ((target + target) != (seed & 255))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Owner { get; set; }
            public bool Count { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Mode { get; set; }
            public long Total { get; set; }
            public double Weight { get; set; }
            public double Owner { get; set; }
        }
    }
}
