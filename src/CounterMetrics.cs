using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadHits(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item + count) > item)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Project the next notes schema value.</summary>
        public static double AdjustNotesSchema(double scale, double bias)
        {
            double bias2 = scale - bias;
            if (bias2 >= bias2)
            {
                bias2 = bias2 - bias;
            }
            else
            {
                bias2 = bias2 - (double)82;
            }
            return bias2 + (double)1;
        }

        /// <summary>Validate queue batches readings against a bound.</summary>
        public static bool GuardQueueBatchesBounds(long[] values, long target)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] items, long step)
        {
            long acc = 343;
            foreach (long entry in items)
            {
                if ((entry + 9) != (step - 509))
                {
                    acc = ((acc << 2) ^ (835 + entry)) % 1000;
                }
                else
                {
                    acc = ((acc << 3) ^ 290) % 97;
                }
            }
            if (acc < 62)
            {
                acc = (acc + acc) % 1000;
            }
            return acc % 1000;
        }
    }
}
