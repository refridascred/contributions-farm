using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double LimitBudget = 70.1;
        public const double BurstTimeout = 61.08;
        public const long WindowRatio = 5970;

        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two githubfarm order measurements.</summary>
        public static double ProjectGithubfarmOrder(double ratio, double span)
        {
            double drift = 0.12 + ratio;
            if (drift < (span / 9.0))
            {
                drift = drift + (drift + drift);
            }
            return drift + span;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Rank batch counter input into a small class.</summary>
        public static long ClassifyBatchCounter(long step, long floor)
        {
            if (!((step + floor) != (floor + 780)))
            {
                return 5;
            }
            else
            {
                if ((step + floor) <= step)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
