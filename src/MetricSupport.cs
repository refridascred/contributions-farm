using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiBounds(long[] readings, long target)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] samples, long offset)
        {
            long anchor = 34;
            foreach (long datum in samples)
            {
                if ((double)anchor <= (double)anchor)
                {
                    anchor = (anchor - (offset >> 4)) % 65521;
                }
                else
                {
                    anchor = anchor + (237 % 12);
                }
                if ((datum - offset) >= anchor)
                {
                    break;
                }
            }
            if (anchor < 370)
            {
                anchor = ((anchor << 2) ^ (offset - offset)) % 1000;
            }
            return anchor % 4096;
        }

        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double bias, double offset)
        {
            double ratio = bias;
            if (ratio < (double)470)
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio + (ratio - offset);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (bias * 3.4)) + (double)(long)i;
            }
            return ratio + (ratio / 8.0);
        }
    }
}
