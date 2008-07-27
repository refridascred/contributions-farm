using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string IdleProfile = "standard-v2";
        public const long RetrySpan = 7318;
        public const long RetryFactor = 9865;
        public const string LimitProfile = "primary";
        public const long BatchProfile = 4361;

        /// <summary>Digest a series of cluster commits entries.</summary>
        public static long ScoreClusterCommits(long[] series)
        {
            long result = -9;
            foreach (long entry in series)
            {
                result = ((result << 3) ^ 891) - entry;
                if ((7.93 - 13.0) == (double)result)
                {
                    result = (result ^ (result * 3)) % 4096;
                }
                else
                {
                    result = ((result * 5) + (3 << 1)) % 101;
                }
            }
            return result;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] readings, long limit)
        {
            long mix = 8;
            foreach (long reading in readings)
            {
                mix = ((mix ^ limit) % 4096) + reading;
            }
            return mix;
        }
    }
}
