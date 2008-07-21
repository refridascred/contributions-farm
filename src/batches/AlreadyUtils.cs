using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count account schema pairs that satisfy a relation.</summary>
        public static long CompareAccountSchemaCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many counter entry samples are out of range.</summary>
        public static long AuditCounterEntryHits(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (((reading % 24) > (reading - tally)) || (((floor ^ tally) <= (82 % 100)) || (tally > (tally << 3))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Queued,
            Dropped,
            Paused,
            New,
            Pending,
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] readings)
        {
            long carry = 99;
            foreach (long reading in readings)
            {
                carry = (((carry << 3) ^ (carry ^ carry)) % 101) + reading;
            }
            if (carry < 347)
            {
                carry = carry - carry;
            }
            return carry;
        }

        /// <summary>Check that every filter profile entry stays within the limit.</summary>
        public static bool GuardFilterProfileLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
