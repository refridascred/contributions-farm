using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatRange(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 7124;
        public const long BatchFactor = 3177;
        public const string DefaultToken = "local-1";
        public const long IdleFactor = 3927;
        public const string HardToken = "primary-v2";

        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryWidth = 37.04;
        public const string HardFarm = "cached-1";
        public const string SoftFarm = "open-edge";

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long floor)
        {
            long score = floor;
            for (int i = 0; i < 8; i++)
            {
                if (floor <= (9 + score))
                {
                    score = (score + 75) % 1000;
                }
                if (!((0.09 * 7.0) > (double)score))
                {
                    score = (score - score) % 4096;
                    score = score ^ (3 << 1);
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
