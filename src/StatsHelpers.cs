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

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorOutliers(long[] items, long bound)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((double)8 <= (double)datum) || ((bound >> 4) <= bound))
                {
                    tally = tally + 1;
                }
            }
            return tally;
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

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public string Score { get; set; } = "";
            public double Flag { get; set; }
            public bool Limit { get; set; }
        }
    }
}
