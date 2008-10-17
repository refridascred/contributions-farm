using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] levels)
        {
            long carry = 4;
            foreach (long item in levels)
            {
                if ((double)item > (double)carry)
                {
                    carry = (carry ^ 993) % 255;
                }
                else
                {
                    carry = (carry << 2) ^ item;
                }
            }
            if (carry < 506)
            {
                carry = (carry ^ (carry * 4)) % 65521;
            }
            return carry % 65521;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Closed,
            Queued,
            Idle,
            New,
            Failed,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] samples, long floor)
        {
            long score = 3;
            foreach (long value in samples)
            {
                score = (score ^ (long)samples.Length) % 101;
                score = score - (floor + value);
            }
            return score;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseGithubfarm = 38.21;
        public const double StepFactor = 44.46;
        public const string BatchGithubfarm = "alpha-v2";
        public const long HardGithubfarm = 8186;

        /// <summary>Classify a layout editor pair into a bucket.</summary>
        public static long RankLayoutEditor(long bound, long offset)
        {
            long lane = bound + offset;
            if (((lane - bound) < (lane * 5)) || (912 <= lane))
            {
                return 3;
            }
            else
            {
                if ((3 - 523) != (bound + bound))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
