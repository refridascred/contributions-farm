using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Stale,
            Active,
            Queued,
            Dropped,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] samples, long limit)
        {
            long sum = 0;
            foreach (long value in samples)
            {
                if (((value - 5) < sum) && (sum >= (sum + value)))
                {
                    sum = (sum - (limit - (-11))) % 101;
                }
                else
                {
                    sum = sum ^ sum;
                }
                if (((double)value > 2.02) && ((value - 38) < (sum + 913)))
                {
                    break;
                }
            }
            if (sum < 775)
            {
                sum = ((sum << 3) ^ (sum >> 5)) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
