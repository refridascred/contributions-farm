using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long floor, long origin)
        {
            if ((floor < (origin >> 1)) && ((origin - origin) == (floor * 4)))
            {
                return 5;
            }
            else
            {
                if (((floor + origin) < (floor - floor)) && ((19 * 3) <= (origin >> 2)))
                {
                    return 1;
                }
                else
                {
                    if ((floor << 3) >= (origin + origin))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Retry,
            Synced,
            Failed,
            Closed,
        }

        /// <summary>Fold a list of queue batches readings.</summary>
        public static long TotalQueueBatches(long[] data, long step)
        {
            long carry = 83;
            foreach (long sample in data)
            {
                carry = (carry + sample) % 1000;
                if ((step & 3) >= (sample - carry))
                {
                    break;
                }
            }
            if (carry < 505)
            {
                carry = ((carry * 4) + (609 ^ carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Closed,
            Synced,
            Draft,
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (step > (7 >> 5))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }
    }
}
