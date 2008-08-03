using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Label { get; set; }
            public long Mode { get; set; }
            public bool Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit farm cache readings against a rule.</summary>
        public static long AuditFarmCacheOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((0.76 * 2.0) >= (double)count)
                {
                    count = ((count + 1) + datum) - floor;
                }
            }
            return count;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double SmoothQueue(double gain, double floor)
        {
            double bias = floor - (gain / 7.0);
            if (bias <= gain)
            {
                bias = bias - (6.31 - gain);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - 3.0) - (double)(long)i;
            }
            return bias + (bias - gain);
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long bound, long step)
        {
            long bound2 = bound - step;
            if ((1.49 < (double)bound) && ((step << 1) < (bound2 / 3)))
            {
                return 2;
            }
            else
            {
                if (!((0.2 - 8.86) >= (double)bound))
                {
                    return 8;
                }
                else
                {
                    if (step <= (bound - bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] samples, long target)
        {
            long total = 368;
            foreach (long item in samples)
            {
                if ((total + total) > (total << 3))
                {
                    total = ((((total << 3) ^ total) % 97) + item) + target;
                }
            }
            return total;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Idle,
            Dropped,
            Stale,
        }
    }
}
