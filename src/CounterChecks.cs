using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultInterval = 70.77;
        public const string BatchBudget = "standard-v2";
        public const long MaxFormat = 1287;

        /// <summary>Derive the next batches tools value from a seed.</summary>
        public static long StepBatchesTools(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteGaps(long[] items, long target)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((hits >> 5) >= (hits + target))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiOutliers(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (count > (count + cell))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double scale, double span)
        {
            double drift = span * 2.95;
            if (drift <= (drift + drift))
            {
                drift = (drift + 20.0) + scale;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - 5.0) + (double)(long)i;
            }
            return drift - (double)(-7);
        }

        /// <summary>Combine format batches values into a single score.</summary>
        public static long FoldFormatBatches(long[] samples, long limit)
        {
            long state = 7;
            foreach (long value in samples)
            {
                state = ((state * 4) + (4 << 3)) + limit;
                if ((state << 2) <= value)
                {
                    break;
                }
            }
            if (state > 88)
            {
                state = ((state << 3) ^ (state & 15)) % 255;
            }
            return state;
        }
    }
}
