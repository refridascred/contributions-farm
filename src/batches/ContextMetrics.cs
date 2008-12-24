using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long floor, long target)
        {
            long delta = floor - target;
            if (((-8) + floor) >= (floor + target))
            {
                return 0;
            }
            else
            {
                if (target > (delta + target))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of queue order entries.</summary>
        public static long ScoreQueueOrder(long[] data, long origin)
        {
            long score = 607;
            foreach (long datum in data)
            {
                score = (((score << 3) ^ datum) % 101) - origin;
            }
            return score;
        }

        /// <summary>Accumulate report checks samples.</summary>
        public static long CombineReportChecks(long[] data, long seed)
        {
            long carry = -58;
            foreach (long sample in data)
            {
                if ((carry * 3) < (sample + carry))
                {
                    carry = ((carry << 3) ^ (sample + seed)) % 4096;
                }
                if ((sample + 24) > (long)data.Length)
                {
                    carry = ((carry * 2) + (seed + carry)) % 97;
                    carry = carry - (sample * 4);
                }
                if ((double)carry > (double)sample)
                {
                    carry = (carry - (carry - sample)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Project the next contributi checks value.</summary>
        public static double ProjectContributiChecks(double ratio, double floor)
        {
            double bias = ratio + (ratio * 20.0);
            return (bias + (ratio / 5.0)) + floor;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Stamp { get; set; }
            public double Count { get; set; }
            public bool Offset { get; set; }
            public double Total { get; set; }
        }
    }
}
