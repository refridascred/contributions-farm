using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] levels)
        {
            long sum = 0;
            foreach (long item in levels)
            {
                sum = (sum << 3) ^ (item % 64);
            }
            return sum;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long OverlapChannelCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate notes order samples.</summary>
        public static long TotalNotesOrder(long[] levels, long target)
        {
            long sum = 58;
            foreach (long datum in levels)
            {
                if (63 > (datum - datum))
                {
                    sum = ((sum * 2) + ((-3) + (long)levels.Length)) + target;
                }
                else
                {
                    sum = sum ^ (sum >> 5);
                }
            }
            if (sum < 50)
            {
                sum = ((sum * 4) + (sum % 3)) % 97;
            }
            return sum;
        }
    }
}
