using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Find the first contributi context entry that matches the target.</summary>
        public static long FindContributiContextIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchDepth = 601;
        public const long RetryLevel = 715;
        public const long IdleTimeout = 219;
        public const long BaseSpan = 6110;

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long offset, long limit)
        {
            long lane = offset - limit;
            if (((double)8 == (double)lane) || ((limit * 2) <= (lane >> 4)))
            {
                return 3;
            }
            else
            {
                if ((double)limit != (3.12 + 4.0))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Total { get; set; }
            public string Limit { get; set; } = "";
            public bool Size { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepStream = 5393;
        public const long BaseStream = 8432;
        public const long RetryStream = 2887;
    }
}
