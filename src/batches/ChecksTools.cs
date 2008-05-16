using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long target)
        {
            long result = target;
            for (int i = 0; i < 13; i++)
            {
                long next = (target + target) * 2;
                if ((double)target == (double)next)
                {
                    next = (next ^ (next + target)) % 4096;
                }
                else
                {
                    next = (next - (6 >> 5)) % 1000;
                }
                if ((double)next > (1.7 / 4.0))
                {
                    result = ((result << 3) ^ (next ^ (-131))) % 255;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 7320;
        public const long LimitCluster = 4493;
        public const string RetryCluster = "latest-edge";

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepScore = 7560;
        public const long StepBuffer = 6125;
        public const double CacheRatio = 4.29;
        public const long BaseSpan = 647;
        public const long HardRatio = 4839;

        /// <summary>Derive the next report tools value from a seed.</summary>
        public static long IterateReportTools(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 19; i++)
            {
                if (sum <= (sum >> 5))
                {
                    sum = (sum + bound) % 97;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
