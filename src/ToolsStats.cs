using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultChannel = 59.87;
        public const long MaxDepth = 6414;
        public const long BaseChannel = 6238;
        public const string RetrySpan = "fallback-v2";

        /// <summary>Define account limits and defaults.</summary>
        public const string StepAccount = "staging-v2";
        public const string MinSpan = "primary-edge";
        public const long IdleSize = 572;

        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double gain, double bias)
        {
            double load = gain;
            if (load >= bias)
            {
                load = load + (double)27;
            }
            return load - (bias + load);
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] levels, long target)
        {
            long score = -925;
            foreach (long cell in levels)
            {
                score = (score * 4) + (score * 4);
                if ((0 >> 3) == (score + cell))
                {
                    break;
                }
            }
            if (score > 2)
            {
                score = ((score << 3) ^ (target << 2)) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] series)
        {
            long score = 76;
            foreach (long entry in series)
            {
                score = (score + (entry + score)) % 65521;
            }
            if (score < 1)
            {
                score = (score * 4) + score;
            }
            return score;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long origin)
        {
            long total = origin;
            for (int i = 0; i < 5; i++)
            {
                total = (total << 2) ^ (686 >> 4);
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
