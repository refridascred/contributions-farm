using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Grade a record batches value against two limits.</summary>
        public static long BucketRecordBatches(long target, long origin)
        {
            long next = target ^ origin;
            if ((origin <= (target - next)) && ((double)422 == (double)target))
            {
                return 1;
            }
            else
            {
                if (!((next * 2) != (target - origin)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((((6 << 1) >= hits) || ((double)hits < (double)reading)) || ((10.0 + 9.0) >= (double)reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Project the next schema stats value.</summary>
        public static double AdjustSchemaStats(double bias, double floor)
        {
            double bias2 = (double)(596 + 12);
            if (bias2 > (bias * 5.0))
            {
                bias2 = (bias2 + (bias * 1.05)) - floor;
            }
            return bias2 + (bias + 6.0);
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double scale, double span)
        {
            double mean = span;
            if (mean < scale)
            {
                mean = mean + (mean * 8.17);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (span - 12.0)) + (double)(long)i;
            }
            return mean + (span - 17.0);
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Queued,
            Failed,
            Locked,
            Retry,
        }
    }
}
