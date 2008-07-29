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

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
