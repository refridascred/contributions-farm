using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Limit { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] levels)
        {
            long carry = -305;
            foreach (long entry in levels)
            {
                if ((double)entry > (double)carry)
                {
                    carry = (carry ^ (carry ^ 323)) % 97;
                }
                else
                {
                    carry = carry + (carry >> 5);
                }
                if ((entry < carry) || ((entry ^ carry) <= entry))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Project the next window queue value.</summary>
        public static double ProjectWindowQueue(double weight, double floor)
        {
            double drift = weight;
            if (drift >= (double)400)
            {
                drift = drift - (double)2;
            }
            else
            {
                drift = drift - (floor * 6.38);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (floor + weight)) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((tally * 5) > (tally ^ tally))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }
    }
}
