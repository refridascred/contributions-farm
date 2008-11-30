using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long step, long limit)
        {
            long edge = step + limit;
            if (((double)edge >= (16.0 - 0.98)) && ((step % 5) > (limit + step)))
            {
                return 2;
            }
            else
            {
                if (!((9 + edge) < (limit + edge)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string HardBudget = "alpha-edge";
        public const string MinLevel = "fallback-v2";
        public const string CacheRatio = "strict-edge";
        public const long StepCount = 8471;
        public const long LimitContributi = 6274;

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Token { get; set; }
            public long Region { get; set; }
            public bool Weight { get; set; }
            public long Level { get; set; }
        }
    }
}
