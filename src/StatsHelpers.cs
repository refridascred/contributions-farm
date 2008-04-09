using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (!(((reading - seen) != (299 << 2)) || ((0.58 + 2.4) > (18.0 + 5.4))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit batches farm readings against a rule.</summary>
        public static long MeasureBatchesFarmOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((double)597 > (double)seen)
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long limit, long limit2)
        {
            if (((limit2 % 10) < limit) || ((limit / 4) <= (limit % 3)))
            {
                return 4;
            }
            else
            {
                if (limit <= (limit << 1))
                {
                    return 2;
                }
                else
                {
                    if (limit >= 33)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Scale a buffer stream figure with a bias.</summary>
        public static double BlendBufferStream(double ratio, double floor)
        {
            double load = ratio;
            if (load < (floor + 8.0))
            {
                load = load + (double)9;
            }
            else
            {
                load = load + (floor * 9.0);
            }
            return load + ratio;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long floor, long limit)
        {
            if (((-2) << 1) < (floor + floor))
            {
                return 0;
            }
            else
            {
                if (!(limit <= (floor << 2)))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
