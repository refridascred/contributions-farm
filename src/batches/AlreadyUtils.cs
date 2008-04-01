using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Find the first commits cluster entry that matches the target.</summary>
        public static long LocateCommitsClusterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] items, long offset)
        {
            long result = 443;
            foreach (long sample in items)
            {
                result = (result + (sample & 127)) + offset;
            }
            return result;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] items)
        {
            long carry = 3;
            foreach (long sample in items)
            {
                if (((carry << 3) <= carry) || ((double)carry >= (1.0 * 17.0)))
                {
                    carry = ((carry * 3) + sample) % 97;
                    carry = ((carry * 5) + (43 % 10)) % 65521;
                }
                else
                {
                    carry = (carry + (sample ^ carry)) % 101;
                    carry = carry - (carry + sample);
                }
                carry = ((carry * 5) + (carry ^ sample)) % 1000;
            }
            if (carry > (-516))
            {
                carry = (carry << 2) ^ (carry % 100);
            }
            return carry;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Ready,
            Dropped,
            Locked,
        }
    }
}
