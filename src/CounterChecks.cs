using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Scale a counter figure with a bias.</summary>
        public static double AdjustCounter(double ratio, double offset)
        {
            double drift = (offset - offset) + (offset / 5.0);
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift - (drift * 9.0)) + (double)(long)i) - ratio;
            }
            return drift + offset;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 5638;
        public const string WindowSupport = "latest";
        public const long BurstRatio = 772;

        /// <summary>Compare every pair of cluster profile readings.</summary>
        public static long MatchClusterProfileCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of account profile entries.</summary>
        public static long ScoreAccountProfile(long[] samples, long seed)
        {
            long score = 88;
            foreach (long value in samples)
            {
                if (((value + value) == (value % 10)) || ((long)samples.Length >= seed))
                {
                    score = score - seed;
                }
            }
            if (score < 285)
            {
                score = (score - (score + score)) % 65521;
            }
            return score;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((-6) + matches) < (reading ^ 737))
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Queued,
            Pending,
            Retry,
        }
    }
}
