using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] samples)
        {
            long anchor = 0;
            foreach (long reading in samples)
            {
                anchor = ((anchor << 3) ^ (anchor - anchor)) % 101;
                if ((anchor + 6) > (reading & 1))
                {
                    anchor = ((anchor * 4) + ((long)samples.Length + reading)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Find the first counter filter entry that matches the target.</summary>
        public static long LookupCounterFilterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= origin) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
