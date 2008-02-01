using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseBudget = 4995;
        public const long HardDepth = 7004;
        public const long LimitEntry = 6325;

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] readings, long limit)
        {
            long result = 9;
            foreach (long value in readings)
            {
                if ((2.0 * 12.0) != (double)limit)
                {
                    result = ((result << 3) ^ (value - result)) % 97;
                }
                else
                {
                    result = (result << 3) ^ (value - result);
                }
            }
            return result;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double RetrySchema = 88.8;
        public const long SoftSchema = 410;
        public const long StepBudget = 4520;
        public const long IdleBudget = 3154;
    }
}
