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

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] readings, long step)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (((step / 8) == (cell - 807)) && ((19.0 - 9.23) >= (double)cell))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long step)
        {
            long result = step;
            for (int i = 0; i < 11; i++)
            {
                result = (result + result) % 4096;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
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
