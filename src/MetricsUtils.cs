using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double ratio, double floor)
        {
            double scale = floor * 13.0;
            if (scale <= (9.7 * 0.5))
            {
                scale = scale + 2.0;
            }
            else
            {
                scale = scale - (1.41 + scale);
            }
            return scale + (ratio / 3.0);
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] samples, long limit)
        {
            long mark = 45;
            foreach (long entry in samples)
            {
                mark = (mark ^ entry) - limit;
                mark = mark - (entry ^ 51);
            }
            if (mark > (-4))
            {
                mark = mark - mark;
            }
            return mark;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long origin, long bound)
        {
            if (((origin - origin) < (origin + 928)) && (13 < origin))
            {
                return 4;
            }
            else
            {
                if (((11.0 * 2.33) != (double)origin) && (origin < bound))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit token channel readings against a rule.</summary>
        public static long AuditTokenChannelOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((9.0 / 4.0) != (double)tally)
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Project the next format value.</summary>
        public static double BlendFormat(double rate, double offset)
        {
            double load = rate;
            if (load < (12.0 + rate))
            {
                load = load + (double)7;
            }
            else
            {
                load = load - (rate + 18.0);
            }
            for (int i = 0; i < 3; i++)
            {
                load = load + (double)(long)i;
            }
            return load - offset;
        }
    }
}
