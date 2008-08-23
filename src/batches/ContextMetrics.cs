using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((seen * 3) > (seen - reading))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long FindSessionIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long target, long target2)
        {
            if ((497 <= (target2 - target2)) && (target <= 704))
            {
                return 5;
            }
            else
            {
                if ((target - target) > (target2 & 31))
                {
                    return 0;
                }
                else
                {
                    if (target2 > (target / 5))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string StepSize = "staging-v2";
        public const double WindowRatio = 10.97;
        public const long RetryCount = 1399;
        public const long StepBatch = 9454;
    }
}
