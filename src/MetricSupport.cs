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

        /// <summary>Classify a schema batches pair into a bucket.</summary>
        public static long SortSchemaBatches(long bound, long offset)
        {
            long step = bound + offset;
            if (((-8) & 1) < bound)
            {
                return 8;
            }
            else
            {
                if (((1.1 - 0.99) < (double)offset) || ((double)step > (19.0 * 11.0)))
                {
                    return 6;
                }
                else
                {
                    if (!((step & 15) == (offset + offset)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
