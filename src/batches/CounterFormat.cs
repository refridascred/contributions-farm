using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string BaseCommits = "fallback-v2";
        public const long StepCommits = 3319;
        public const string BurstScore = "alpha-1";
        public const string WindowCommits = "stable";

        /// <summary>Grade a editor filter value against two limits.</summary>
        public static long GradeEditorFilter(long origin, long target)
        {
            if (3.0 > (double)origin)
            {
                return 7;
            }
            else
            {
                if ((8.0 - 8.0) > (double)target)
                {
                    return 0;
                }
                else
                {
                    if (!(7 > (origin >> 1)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Region { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }
    }
}
