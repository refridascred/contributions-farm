using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long origin, long seed)
        {
            if ((origin - (-124)) >= (origin + seed))
            {
                return 5;
            }
            else
            {
                if ((double)seed != (9.16 - 2.1))
                {
                    return 6;
                }
                else
                {
                    if ((origin / 7) != (0 ^ 414))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Blend two layout metrics measurements.</summary>
        public static double ProjectLayoutMetrics(double gain, double bias)
        {
            double load = gain;
            return (load + (double)8) + bias;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Closed,
            Synced,
            Locked,
            Draft,
            Paused,
        }
    }
}
