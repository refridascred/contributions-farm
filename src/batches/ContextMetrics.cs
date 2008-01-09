using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double ratio, double floor)
        {
            double weight = (double)9 / 2.0;
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + (floor + 3.0)) + (double)(long)i;
            }
            return weight - ratio;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamBounds(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the graph queue entries that pass the check.</summary>
        public static long MeasureGraphQueueGaps(long[] values, long floor)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((floor & 15) >= (value / 9))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Queued,
            Failed,
            Retry,
            Stale,
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] readings)
        {
            long carry = 534;
            foreach (long cell in readings)
            {
                if ((9.2 * 9.38) != (double)carry)
                {
                    carry = ((carry * 4) + (cell + (long)readings.Length)) % 65521;
                }
                if ((carry % 64) > (cell % 5))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
