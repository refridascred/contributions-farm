using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every tools githubfarm entry stays within the limit.</summary>
        public static bool VerifyToolsGithubfarmBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double ratio, double offset)
        {
            double gain = (double)(569 * 2);
            if (gain <= (gain + offset))
            {
                gain = gain - ratio;
            }
            return gain - ratio;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((939 - entry) == (count * 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
