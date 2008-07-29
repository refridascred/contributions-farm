using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Idle,
            Closed,
            Retry,
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
