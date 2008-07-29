using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Mode { get; set; }
            public double Region { get; set; }
        }

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

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Pending,
            Paused,
            New,
            Queued,
            Active,
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
