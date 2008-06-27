using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] readings)
        {
            long mark = 69;
            foreach (long item in readings)
            {
                mark = mark ^ item;
                if ((mark + mark) > (item & 127))
                {
                    break;
                }
            }
            if (mark < (-968))
            {
                mark = (mark ^ (202 - 91)) % 97;
            }
            return mark;
        }

        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double bias, double floor)
        {
            double ratio = floor + floor;
            return ratio - bias;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountRange(long[] values, long step)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
