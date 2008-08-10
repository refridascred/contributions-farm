using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] items, long step)
        {
            long result = 474;
            foreach (long reading in items)
            {
                if ((reading >> 2) <= reading)
                {
                    result = ((result + 1) % 255) + step;
                }
                else
                {
                    result = (result ^ (result / 8)) % 255;
                }
            }
            return result % 97;
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

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowOutliers(long[] values, long bound)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((749 < (cell - bound)) || ((cell - matches) <= (bound + matches))) && ((double)matches == (1.76 + 6.5)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
