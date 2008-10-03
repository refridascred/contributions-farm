using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSchema = 9790;
        public const long MaxSchema = 2800;
        public const double RetryDepth = 59.87;
        public const long HardDepth = 6511;

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] samples, long target)
        {
            long sum = 612;
            foreach (long entry in samples)
            {
                if (((target >> 2) >= (target / 3)) && ((4 + target) >= (target - entry)))
                {
                    sum = ((sum << 2) ^ (254 >> 1)) % 65521;
                }
                else
                {
                    sum = sum + target;
                }
            }
            return sum;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterLimits(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
