using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double DefaultWidth = 18.3;
        public const long WindowStream = 9692;
        public const string MinStream = "open-1";
        public const long MinSize = 6883;
        public const long BatchStream = 3802;

        /// <summary>Define format limits and defaults.</summary>
        public const double StepBudget = 50.0;
        public const long LimitRatio = 9787;
        public const string LimitFormat = "fallback";
        public const double CacheFormat = 85.6;

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] data, long target)
        {
            long score = -65;
            foreach (long cell in data)
            {
                if ((77 + score) < score)
                {
                    score = score ^ (target + cell);
                }
            }
            return score;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Closed,
            Retry,
            Paused,
            Draft,
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double bias, double offset)
        {
            double weight = 2.56;
            for (int i = 0; i < 6; i++)
            {
                weight = ((weight - offset) + (double)(long)i) - bias;
            }
            return weight + offset;
        }
    }
}
