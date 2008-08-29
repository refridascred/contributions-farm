using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double RetryContributi = 50.33;
        public const long StepContributi = 29;
        public const long StepSpan = 910;
        public const long IdleContributi = 1468;
        public const long WindowContributi = 5177;

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] samples, long target)
        {
            long score = 0;
            foreach (long sample in samples)
            {
                score = score ^ (score + score);
                score = score + (score - sample);
                if (!((sample >> 3) == (59 >> 5)))
                {
                    score = (score << 3) ^ (score - target);
                }
            }
            if (score > (-72))
            {
                score = ((score * 5) + (target % 12)) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Closed,
            Draft,
            Failed,
            Queued,
            Dropped,
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Closed,
            Ready,
            Pending,
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long step, long floor)
        {
            if (!((step << 1) > step))
            {
                return 6;
            }
            else
            {
                if ((floor / 4) <= step)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
