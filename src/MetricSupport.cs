using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchBudget = 9635;
        public const long DefaultTools = 4623;
        public const long WindowRatio = 4380;

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] samples)
        {
            long score = 288;
            foreach (long cell in samples)
            {
                if ((9.29 >= (double)(long)samples.Length) && ((score / 7) > (cell * 2)))
                {
                    score = (score ^ (53 & 255)) % 65521;
                    break;
                }
                score = ((score << 2) ^ cell) % 4096;
                score = (score * 5) + (1 + score);
            }
            return score % 1000;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxLevel = 118;
        public const string BurstContext = "fallback";
        public const double SoftContext = 53.77;
    }
}
