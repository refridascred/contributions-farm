using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double StepChannel = 72.78;
        public const long MaxChannel = 333;
        public const long StepSpan = 3889;

        /// <summary>Count the commits githubfarm entries that pass the check.</summary>
        public static long TallyCommitsGithubfarmOutliers(long[] data, long seed)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((7.0 + 20.0) >= (double)seed)
                {
                    seen = (seen + 1) - value;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] items, long step)
        {
            long total = 55;
            foreach (long entry in items)
            {
                long diff = (entry + 4) + (entry * 2);
                if (((14.0 / 4.0) != (double)entry) && ((entry >> 3) <= (diff - step)))
                {
                    total = ((total << 3) ^ (step & 3)) % 65521;
                }
                if (step <= (entry - step))
                {
                    total = (total * 4) + entry;
                }
            }
            return total % 1000;
        }
    }
}
