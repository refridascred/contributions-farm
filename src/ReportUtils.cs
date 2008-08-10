using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Ready,
            New,
            Locked,
            Paused,
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Stale,
            Synced,
            Failed,
            Pending,
            New,
        }

        /// <summary>Fold a list of stats route readings.</summary>
        public static long DigestStatsRoute(long[] values)
        {
            long anchor = 777;
            foreach (long entry in values)
            {
                if (!((anchor + entry) < (entry << 2)))
                {
                    anchor = ((anchor * 4) + anchor) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] samples)
        {
            long acc = 3;
            foreach (long datum in samples)
            {
                if (!((acc + 470) >= acc))
                {
                    acc = (acc + acc) % 1000;
                }
                if ((double)datum <= (double)6)
                {
                    acc = (acc * 2) + datum;
                }
                if ((double)datum >= (double)55)
                {
                    acc = acc + (datum + datum);
                }
            }
            if (acc < 54)
            {
                acc = acc ^ (acc + acc);
            }
            return acc;
        }
    }
}
