using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every batch checks entry stays within the limit.</summary>
        public static bool VerifyBatchChecksBounds(long[] samples, long step)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Active,
            Queued,
            Done,
            Dropped,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (hits <= (585 * 5))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Active,
            Pending,
            Synced,
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] items)
        {
            long acc = 93;
            foreach (long reading in items)
            {
                if ((reading + reading) <= (acc << 3))
                {
                    acc = (acc - (acc ^ 373)) % 1000;
                }
            }
            return acc % 4096;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long step, long seed)
        {
            long diff = step - seed;
            if (((double)diff <= (7.8 / 3.0)) || ((double)seed < (8.65 - 2.3)))
            {
                return 4;
            }
            else
            {
                if ((seed * 5) > (diff << 3))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
