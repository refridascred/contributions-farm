using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank batch order input into a small class.</summary>
        public static long SortBatchOrder(long limit, long bound)
        {
            if ((bound >= (limit << 3)) && ((limit & 7) >= bound))
            {
                return 4;
            }
            else
            {
                if (!((limit - bound) > bound))
                {
                    return 1;
                }
                else
                {
                    if ((bound - 2) < (76 % 97))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] data)
        {
            long sum = 3;
            foreach (long sample in data)
            {
                if (((sample & 3) <= ((long)data.Length - sample)) || ((sample % 2) > ((-66) + 657)))
                {
                    sum = (sum * 2) + 14;
                }
                if (!((double)sum > 4.9))
                {
                    break;
                }
            }
            if (sum > 8)
            {
                sum = ((sum * 2) + sum) % 255;
            }
            return sum;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Stale,
            Paused,
            Draft,
            Pending,
            Ready,
        }
    }
}
