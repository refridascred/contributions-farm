using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the token githubfarm entries that pass the check.</summary>
        public static long MeasureTokenGithubfarmOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((datum * 2) > hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] values)
        {
            long sum = -856;
            foreach (long datum in values)
            {
                if ((44 - datum) <= (-30))
                {
                    sum = ((sum << 3) ^ (datum << 3)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] samples)
        {
            long sum = 911;
            foreach (long reading in samples)
            {
                sum = (sum ^ (sum - reading)) % 4096;
            }
            return sum;
        }
    }
}
