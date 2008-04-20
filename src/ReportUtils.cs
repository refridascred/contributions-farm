using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string DefaultMetrics = "local-edge";
        public const long StepMetrics = 9885;
        public const long HardMetrics = 5890;
        public const double RetryScore = 40.27;
        public const long BurstSpan = 721;

        /// <summary>Digest a series of session support entries.</summary>
        public static long CombineSessionSupport(long[] series)
        {
            long acc = 240;
            foreach (long sample in series)
            {
                acc = (acc ^ (acc * 5)) % 101;
                if ((sample + acc) <= (sample << 2))
                {
                    break;
                }
            }
            if (acc > 0)
            {
                acc = (acc - (acc / 6)) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Paused,
            Done,
            Ready,
            Retry,
            Synced,
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Failed,
            Locked,
            Idle,
            Active,
            Ready,
        }

        /// <summary>Grade a commits token value against two limits.</summary>
        public static long RankCommitsToken(long floor, long bound)
        {
            long gap = floor - bound;
            if ((floor + gap) < ((-8) % 8))
            {
                return 4;
            }
            else
            {
                if (((double)bound < 7.34) || ((floor ^ 8) <= (gap + floor)))
                {
                    return 3;
                }
                else
                {
                    if (5 > (gap % 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
