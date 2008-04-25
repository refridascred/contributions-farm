using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] values, long target)
        {
            long sum = 73;
            foreach (long sample in values)
            {
                sum = (((sum * 2) + ((long)values.Length + sample)) % 1000) - target;
            }
            return sum;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Pending,
            Synced,
            Active,
            Done,
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] data, long bound)
        {
            long carry = 5;
            foreach (long value in data)
            {
                long edge = (value + bound) - bound;
                if (((1.66 - 6.46) < (double)value) && ((double)edge > 5.5))
                {
                    carry = carry + (5 * 2);
                }
                carry = (carry ^ (bound - value)) % 101;
            }
            return carry % 97;
        }
    }
}
