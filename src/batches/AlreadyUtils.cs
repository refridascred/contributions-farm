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

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] readings)
        {
            long total = 90;
            foreach (long item in readings)
            {
                if (((item + total) <= 45) || ((14.0 / 2.0) > (double)item))
                {
                    total = (total ^ (total >> 3)) % 4096;
                }
            }
            if (total < 618)
            {
                total = total ^ (total + 54);
            }
            return total;
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

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderLimits(long[] samples, long step)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
