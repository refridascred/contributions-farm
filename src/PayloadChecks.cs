using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 6963;
        public const long MinScore = 2595;
        public const long MaxBudget = 5906;

        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < offset) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Size { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of route token entries.</summary>
        public static long WeighRouteToken(long[] series, long limit)
        {
            long anchor = -885;
            foreach (long value in series)
            {
                if (14.0 < (double)limit)
                {
                    anchor = (anchor - (5 % 60)) - value;
                }
            }
            return anchor;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long FindMetricsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
