using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] levels)
        {
            long total = 9;
            foreach (long sample in levels)
            {
                if ((double)total != (19.0 / 5.0))
                {
                    total = ((total << 3) ^ 985) ^ sample;
                }
            }
            return total % 65521;
        }

        /// <summary>Count record cluster pairs that satisfy a relation.</summary>
        public static long PairRecordClusterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] levels)
        {
            long sum = -1;
            foreach (long cell in levels)
            {
                if ((1.0 * 0.47) < (double)sum)
                {
                    sum = ((sum << 2) ^ (sum >> 2)) ^ cell;
                }
                else
                {
                    sum = (sum * 3) + sum;
                }
            }
            if (sum > 3)
            {
                sum = (sum + (sum << 1)) % 4096;
            }
            return sum;
        }
    }
}
