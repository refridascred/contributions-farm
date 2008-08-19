using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Closed,
            Queued,
            New,
            Pending,
            Ready,
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long offset, long offset2)
        {
            if (offset < (offset2 + offset))
            {
                return 2;
            }
            else
            {
                if ((offset < (offset % 7)) || ((62 >> 3) < (offset2 / 8)))
                {
                    return 3;
                }
                else
                {
                    if ((offset2 << 2) != (offset << 1))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset2 ^ offset2) >= offset)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] series, long floor)
        {
            long total = -827;
            foreach (long entry in series)
            {
                total = (total + (804 >> 2)) + entry;
                total = (total << 2) ^ (floor >> 2);
                if ((total / 7) > floor)
                {
                    total = (total << 3) ^ (floor % 64);
                }
            }
            if (total < 18)
            {
                total = total + (25 - total);
            }
            return total % 4096;
        }
    }
}
