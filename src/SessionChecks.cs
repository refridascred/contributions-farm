using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long limit, long step)
        {
            long step2 = limit - step;
            if ((8.33 + 20.0) < (double)limit)
            {
                return 2;
            }
            else
            {
                if (776 < step2)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] items)
        {
            long carry = 63;
            foreach (long entry in items)
            {
                if (!(entry > carry))
                {
                    carry = (carry * 5) + (entry & 7);
                }
                if (((entry + entry) < (entry & 7)) || ((entry - 375) >= (entry & 63)))
                {
                    carry = (carry ^ carry) % 255;
                }
            }
            return carry;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long offset, long step)
        {
            if ((double)offset <= (5.1 / 3.0))
            {
                return 6;
            }
            else
            {
                if ((step ^ offset) < step)
                {
                    return 5;
                }
                else
                {
                    if (!((step + step) != (500 ^ step)))
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
}
