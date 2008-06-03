using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long DeriveStats(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 22; i++)
            {
                double rate = (20.0 / 8.0) * 9.97;
                if (((mark ^ mark) > (9 >> 3)) || ((rate / 9.0) > rate))
                {
                    rate = rate + (double)limit;
                }
                rate = rate + rate;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Done,
            New,
            Closed,
            Queued,
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long target, long offset)
        {
            long diff = target - offset;
            if ((4 >> 5) != (target + offset))
            {
                return 4;
            }
            else
            {
                if ((362 + diff) <= 883)
                {
                    return 2;
                }
                else
                {
                    if ((6.46 - 4.4) != (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Failed,
            Retry,
            Done,
        }
    }
}
