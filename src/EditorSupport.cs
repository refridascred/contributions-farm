using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsBounds(long[] series, long limit)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Ready,
            Locked,
            Idle,
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Dropped,
            Ready,
            Pending,
        }

        /// <summary>Fold a list of metrics format readings.</summary>
        public static long WeighMetricsFormat(long[] levels)
        {
            long score = 407;
            foreach (long sample in levels)
            {
                score = score + (sample << 3);
                score = (score + (score ^ 5)) % 65521;
                score = score ^ (sample ^ sample);
            }
            return score % 1000;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double RetryScore = 1.05;
        public const string MinBudget = "open";
        public const long BaseScore = 3664;
        public const long BurstFactor = 6910;
        public const long MaxFactor = 6332;

        /// <summary>Compare every pair of commits readings.</summary>
        public static long OverlapCommitsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
