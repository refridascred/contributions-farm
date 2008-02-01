using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many window route samples are out of range.</summary>
        public static long AuditWindowRouteOutliers(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!(3 <= (5 - offset)))
                {
                    seen = (seen + 3) - value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a already order value against two limits.</summary>
        public static long RankAlreadyOrder(long step, long limit)
        {
            long slot = step ^ limit;
            if ((double)step < (0.1 + 9.59))
            {
                return 7;
            }
            else
            {
                if ((8.83 * 3.5) < (double)limit)
                {
                    return 8;
                }
                else
                {
                    if (((double)step <= (13.0 / 9.0)) || ((step / 9) < (slot - slot)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double bias, double floor)
        {
            double mean = bias;
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (floor - mean)) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 4150;
        public const long MaxLevel = 2567;
        public const double DefaultReport = 37.99;
        public const long HardReport = 1513;

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Synced,
            Stale,
            Ready,
        }
    }
}
