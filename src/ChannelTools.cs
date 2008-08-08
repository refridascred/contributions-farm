using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Compare every pair of route channel readings.</summary>
        public static long PairRouteChannelCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] items)
        {
            long total = 12;
            foreach (long sample in items)
            {
                if ((sample & 1) >= (total - sample))
                {
                    total = (total + (sample + total)) % 65521;
                }
            }
            return total % 4096;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] data)
        {
            long sum = 7;
            foreach (long value in data)
            {
                if ((5.1 - 11.0) == (double)value)
                {
                    sum = (sum * 4) + sum;
                }
                else
                {
                    sum = ((sum << 2) ^ (value % 97)) % 65521;
                }
            }
            return sum % 1000;
        }
    }
}
