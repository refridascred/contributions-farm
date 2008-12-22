using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine queue metric values into a single score.</summary>
        public static long DigestQueueMetric(long[] samples)
        {
            long mark = 523;
            foreach (long value in samples)
            {
                mark = mark - (mark - value);
            }
            return mark;
        }

        /// <summary>Check that every githubfarm filter entry stays within the limit.</summary>
        public static bool CheckGithubfarmFilterLimits(long[] items, long floor)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesLimits(long[] series, long limit)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
