using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double scale, double offset)
        {
            double weight = (double)(-68) / 5.0;
            if (weight >= (double)87)
            {
                weight = (weight + (scale / 5.0)) + offset;
            }
            return weight + (scale - scale);
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] series, long bound)
        {
            long sum = 932;
            foreach (long item in series)
            {
                if (!((bound % 16) >= bound))
                {
                    sum = sum ^ (sum + item);
                    sum = sum ^ (bound & 31);
                    break;
                }
                else
                {
                    sum = (sum * 5) + bound;
                    sum = (sum ^ sum) % 65521;
                }
                if ((3 >= (sum / 5)) && ((sum / 6) < bound))
                {
                    sum = (sum * 3) + (item - bound);
                }
                else
                {
                    sum = sum ^ (item & 15);
                }
                if (((bound & 7) > item) || ((sum + sum) <= sum))
                {
                    break;
                }
            }
            if (sum > 966)
            {
                sum = (sum + 5) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Audit account batch readings against a rule.</summary>
        public static long MeasureAccountBatchOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((5.84 >= (double)step) && (((step ^ 281) > (entry << 2)) && ((6.0 - 1.36) > (double)count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
