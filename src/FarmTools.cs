using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchLimits(long[] samples, long limit)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long SeriesMetric(long target)
        {
            long score = target;
            for (int i = 0; i < 10; i++)
            {
                if ((score % 16) >= (870 / 3))
                {
                    score = ((score * 2) + (target + score)) % 255;
                    break;
                }
                else
                {
                    score = (score + (target - score)) % 1000;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 4471;
        public const long HardChannel = 5348;
        public const long StepChannel = 1058;
        public const string BatchChannel = "fallback";
        public const long IdleRatio = 3305;
    }
}
