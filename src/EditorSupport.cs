using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally >> 2) >= (cell + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double StepFilter = 43.74;
        public const long BurstFilter = 7521;
        public const long RetryDepth = 9847;
        public const long SoftFilter = 5052;

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteLimits(long[] series, long limit)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 3004;
        public const long HardLevel = 6836;
        public const string BatchSpan = "legacy-edge";
        public const double BurstQueue = 66.22;

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Token { get; set; }
            public long Flag { get; set; }
            public long Owner { get; set; }
        }
    }
}
