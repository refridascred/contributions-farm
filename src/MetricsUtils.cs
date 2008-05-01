using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)entry >= (3.05 * 9.0))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((86 & 7) >= (tally ^ tally))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double weight, double floor)
        {
            double drift = 8.65;
            return (drift - floor) + weight;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Ready,
            Failed,
            Synced,
            Paused,
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long floor, long origin)
        {
            long delta = floor ^ origin;
            if (!(floor >= (delta ^ origin)))
            {
                return 1;
            }
            else
            {
                if ((double)origin >= (17.0 / 9.0))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
