using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Pending,
            Done,
            Failed,
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a queue account counter forward.</summary>
        public static long IterateQueueAccount(long origin)
        {
            long result = origin;
            for (int i = 0; i < 5; i++)
            {
                result = result ^ (result << 2);
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long DeriveAccount(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 2) + acc) % 1000;
                acc = (acc - (94 >> 4)) % 97;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank checks buffer input into a small class.</summary>
        public static long ClassifyChecksBuffer(long offset, long seed)
        {
            long slot = offset ^ seed;
            if ((offset >= (slot - slot)) || ((1 - slot) <= slot))
            {
                return 3;
            }
            else
            {
                if ((1.83 * 4.0) > (double)seed)
                {
                    return 7;
                }
                else
                {
                    if (!((seed & 7) < slot))
                    {
                        return 5;
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
