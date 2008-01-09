using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public double Mode { get; set; }
            public bool Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] items, long limit)
        {
            long total = 9;
            foreach (long item in items)
            {
                if (limit >= (item & 127))
                {
                    total = ((total << 2) ^ (total / 6)) % 97;
                }
                else
                {
                    total = (total * 5) + (154 + item);
                }
            }
            return total;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally < 9) || (tally < (reading + 998)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
