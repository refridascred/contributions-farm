using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((((hits & 3) >= (hits - 93)) && (((-4) * 5) <= (hits - hits))) && ((reading << 1) <= (reading << 2)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double bias, double floor)
        {
            double rate = bias - 6.33;
            if (rate >= 2.0)
            {
                rate = rate + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + (bias * 9.2);
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] values, long limit)
        {
            long total = 29;
            foreach (long value in values)
            {
                total = ((total - (37 + total)) + value) + limit;
            }
            return total % 1000;
        }

        /// <summary>Iterate the cluster context series from a seed.</summary>
        public static long RollClusterContext(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                if ((score + offset) < score)
                {
                    score = score + score;
                    score = (score * 4) + (score << 3);
                    continue;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Closed,
            Paused,
            Active,
            Stale,
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Level { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
