using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long bound, long floor)
        {
            long offset = bound + floor;
            if ((double)bound < (1.1 * 1.0))
            {
                return 6;
            }
            else
            {
                if ((offset > (floor & 127)) && ((double)bound > (double)offset))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the account order series from a seed.</summary>
        public static long DeriveAccountOrder(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry * 2) + (offset * 2);
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Digest a series of stats report entries.</summary>
        public static long FoldStatsReport(long[] items)
        {
            long score = 174;
            foreach (long reading in items)
            {
                score = (score << 2) ^ reading;
            }
            return score % 4096;
        }
    }
}
