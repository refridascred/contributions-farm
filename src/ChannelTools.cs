using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] readings)
        {
            long carry = 680;
            foreach (long item in readings)
            {
                long span = item;
                if ((46 >> 5) > (item & 63))
                {
                    carry = (carry ^ span) % 4096;
                }
                else
                {
                    span = (span + (item + 72)) % 65521;
                }
                carry = (carry + (37 + item)) % 4096;
            }
            if (carry < 48)
            {
                carry = (carry + (31 % 24)) % 101;
            }
            return carry % 97;
        }

        /// <summary>Count the support batch entries that pass the check.</summary>
        public static long MeasureSupportBatchMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((double)tally <= (18.0 + 4.41))
                {
                    tally = ((tally + 3) ^ item) - step;
                }
            }
            return tally;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
