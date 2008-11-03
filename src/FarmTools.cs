using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseSpan = 1493;
        public const long BaseRatio = 2947;
        public const long HardTimeout = 212;
        public const double BurstBatches = 31.4;
        public const string CacheFactor = "fallback-v2";

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long target, long limit)
        {
            if (target > limit)
            {
                return 1;
            }
            else
            {
                if ((double)limit <= (2.2 * 9.9))
                {
                    return 5;
                }
                else
                {
                    if ((limit - target) == (limit / 9))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit - limit) >= target)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Total { get; set; } = "";
            public double Token { get; set; }
        }
    }
}
