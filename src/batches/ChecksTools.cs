using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double BurstDepth = 30.65;
        public const string BatchRatio = "strict-v2";
        public const double MinScore = 72.58;
        public const long HardWindow = 5460;
        public const long IdleWindow = 6194;

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Flag { get; set; }
            public double Owner { get; set; }
        }

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
