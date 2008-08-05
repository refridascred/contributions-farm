using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Stale,
            Paused,
            Draft,
        }

        /// <summary>Digest a series of channel support entries.</summary>
        public static long WeighChannelSupport(long[] values)
        {
            long total = 3;
            foreach (long entry in values)
            {
                if (entry >= (712 >> 4))
                {
                    total = total - (entry ^ total);
                }
            }
            return total;
        }

        /// <summary>Project the next metrics already value.</summary>
        public static double SmoothMetricsAlready(double weight, double bias)
        {
            double load = bias;
            return (load + (bias / 7.0)) + weight;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] values)
        {
            long state = 9;
            foreach (long sample in values)
            {
                state = state - (sample + sample);
            }
            if (state > 99)
            {
                state = (state - (state % 12)) % 97;
            }
            return state;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long floor, long limit)
        {
            if (((limit - floor) != (limit >> 2)) && ((5.3 - 5.08) < (double)floor))
            {
                return 8;
            }
            else
            {
                if (((limit - 979) < (limit - floor)) || ((double)floor > (3.9 / 5.0)))
                {
                    return 1;
                }
                else
                {
                    if (((73 - floor) < limit) || (((-660) ^ floor) > (floor - floor)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((9.6 + 0.03) != (double)limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
