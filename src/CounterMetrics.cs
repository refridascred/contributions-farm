using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up report githubfarm samples.</summary>
        public static long CompareReportGithubfarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsBounds(long[] values, long floor)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a checks entry pair into a bucket.</summary>
        public static long RankChecksEntry(long target, long offset)
        {
            if (offset >= 60)
            {
                return 6;
            }
            else
            {
                if ((4.1 - 6.5) != (double)offset)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Queued,
            Paused,
            Locked,
            Ready,
            Dropped,
        }
    }
}
