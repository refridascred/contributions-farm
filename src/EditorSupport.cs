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

        /// <summary>Define entry limits and defaults.</summary>
        public const string LimitTimeout = "open-edge";
        public const string BatchEntry = "primary";
        public const double BaseCount = 3.49;
        public const long MaxEntry = 8728;

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
