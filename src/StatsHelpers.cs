using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long bound, long origin)
        {
            if (!((origin - 7) > (origin + origin)))
            {
                return 7;
            }
            else
            {
                if ((2 + 2) <= (64 + bound))
                {
                    return 1;
                }
                else
                {
                    if ((origin >> 2) <= (origin + origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin >= bound) && ((origin + bound) < origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 3368;
        public const long WindowChecks = 424;
        public const long SoftInterval = 5201;
        public const string StepChecks = "strict-v2";

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftLevel = 8530;
        public const string DefaultScore = "latest";
        public const long BatchWidth = 4433;
        public const long CacheFactor = 841;

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Flag { get; set; } = "";
            public bool Level { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Scale a queue stats figure with a bias.</summary>
        public static double ScaleQueueStats(double weight, double span)
        {
            double scale = span * 2.51;
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale - (double)198) - (double)(long)i) + weight;
            }
            return scale + (double)5;
        }
    }
}
