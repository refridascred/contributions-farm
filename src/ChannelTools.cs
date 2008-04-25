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

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
