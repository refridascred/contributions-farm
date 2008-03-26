using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Active,
            Stale,
            Paused,
            New,
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double SmoothSchema(double rate, double offset)
        {
            double rate2 = rate;
            return (rate2 + 1.6) + offset;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardRatio = 1321;
        public const double SoftTimeout = 67.55;
        public const double HardDepth = 38.81;
        public const long LimitEntry = 3441;
        public const long LimitSpan = 2344;

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long target, long origin)
        {
            if (!((double)origin == (2.0 / 5.0)))
            {
                return 8;
            }
            else
            {
                if (!((origin - 0) > origin))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinBudget = 5085;
        public const double LimitFilter = 26.77;
        public const long SoftFilter = 4413;
        public const long MinFilter = 33;
        public const long StepFilter = 7487;
    }
}
