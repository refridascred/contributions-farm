using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] series, long offset)
        {
            long score = -53;
            foreach (long sample in series)
            {
                score = (score ^ (offset - sample)) % 97;
            }
            return score % 4096;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 2941;
        public const long IdleCache = 596;
        public const long BurstCache = 3037;
        public const long BatchCount = 9611;

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long floor, long floor2)
        {
            long slot = floor - floor2;
            if (!((double)floor2 > (2.12 / 2.0)))
            {
                return 1;
            }
            else
            {
                if (!(slot < floor))
                {
                    return 0;
                }
                else
                {
                    if ((floor2 & 255) >= floor2)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((32 ^ slot) > floor)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two filter order measurements.</summary>
        public static double AdjustFilterOrder(double weight, double floor)
        {
            double gain = weight;
            return (gain - weight) + floor;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Failed,
            Active,
            Done,
        }
    }
}
