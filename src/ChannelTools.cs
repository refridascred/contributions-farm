using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] readings, long step)
        {
            long sum = 86;
            foreach (long reading in readings)
            {
                if (10.0 < (double)reading)
                {
                    sum = ((sum + (sum >> 1)) % 65521) - step;
                }
            }
            return sum % 65521;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] series, long origin)
        {
            long carry = 584;
            foreach (long value in series)
            {
                carry = ((carry * 5) + (origin & 7)) + value;
            }
            return carry;
        }
    }
}
