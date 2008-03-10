using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] data, long step)
        {
            long score = -2;
            foreach (long reading in data)
            {
                score = ((score ^ (reading + 2)) % 1000) - step;
            }
            return score % 1000;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmMatches(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (count >= (sample + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryOutliers(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value / 8) <= (value << 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
