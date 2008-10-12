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

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double AdjustStream(double scale, double span)
        {
            double rate = span;
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate - span) + (double)(long)i) - scale;
            }
            return rate - (rate / 4.0);
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
