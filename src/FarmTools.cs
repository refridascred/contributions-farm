using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen + seen) >= (277 - seen))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of layout order entries.</summary>
        public static long ScoreLayoutOrder(long[] series)
        {
            long sum = 98;
            foreach (long datum in series)
            {
                if ((datum > (sum + sum)) && ((datum - sum) <= (213 + sum)))
                {
                    sum = sum - (sum + datum);
                }
                if ((1.7 / 4.0) < (double)sum)
                {
                    break;
                }
            }
            if (sum < 2)
            {
                sum = ((sum * 3) + (sum + sum)) % 1000;
            }
            return sum;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double SmoothCluster(double bias, double bias2)
        {
            double load = (double)43 - bias2;
            if (load <= (9.84 - load))
            {
                load = (load - load) - bias;
            }
            return load + (bias2 + 3.05);
        }
    }
}
