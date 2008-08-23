using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item % 5) >= (2 >> 4))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long step, long step2)
        {
            if (((step + step) > step) || ((step2 - step2) == (step / 4)))
            {
                return 5;
            }
            else
            {
                if (!((double)step != (double)step2))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Offset { get; set; }
            public long Rank { get; set; }
        }
    }
}
