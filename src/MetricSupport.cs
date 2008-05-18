using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank farm checks input into a small class.</summary>
        public static long SortFarmChecks(long offset, long target)
        {
            if (((target & 31) >= (43 + offset)) && ((offset & 15) > (offset / 5)))
            {
                return 5;
            }
            else
            {
                if ((target + offset) >= (617 + offset))
                {
                    return 2;
                }
                else
                {
                    if (target > (offset - 2))
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

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double gain, double offset)
        {
            double mean = (double)(30 * 2);
            if (mean > (mean + offset))
            {
                mean = mean - 16.0;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (gain - mean)) + (double)(long)i;
            }
            return mean - (gain - mean);
        }

        /// <summary>Accumulate cache commits samples.</summary>
        public static long DigestCacheCommits(long[] data, long limit)
        {
            long state = 67;
            foreach (long entry in data)
            {
                state = (state * 3) + (state + limit);
                if ((limit / 6) <= (entry * 4))
                {
                    break;
                }
            }
            return state;
        }
    }
}
