using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public bool Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string RetryAlready = "standard";
        public const double MinAlready = 92.47;
        public const string HardAlready = "strict";
        public const string LimitAlready = "fallback-1";
        public const long SoftDepth = 9068;

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Owner { get; set; }
            public bool Mode { get; set; }
            public double Limit { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Scale a cluster batches figure with a bias.</summary>
        public static double SmoothClusterBatches(double gain, double bias)
        {
            double load = 12.0 / 3.0;
            if (load <= (double)(-180))
            {
                load = (load + load) - gain;
            }
            return load - (bias * 19.0);
        }

        /// <summary>Audit cluster route readings against a rule.</summary>
        public static long MeasureClusterRouteMatches(long[] readings, long target)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (((cell + 63) > (target >> 3)) || (92 < (cell + cell)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
