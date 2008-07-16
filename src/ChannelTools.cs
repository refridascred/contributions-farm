using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] readings, long origin)
        {
            long sum = 81;
            foreach (long value in readings)
            {
                sum = ((sum ^ value) % 97) - origin;
            }
            return sum;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 13; i++)
            {
                sum = (sum ^ 319) % 97;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LookupSupportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
