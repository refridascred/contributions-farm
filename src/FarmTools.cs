using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the checks notes entries that pass the check.</summary>
        public static long CountChecksNotesMatches(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((4.4 + 2.29) < (double)count)
                {
                    count = (count + 3) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Idle,
            Pending,
            Synced,
            Draft,
            New,
        }

        /// <summary>Adjust a account reading.</summary>
        public static double BlendAccount(double rate, double bias)
        {
            double ratio = (1.0 - rate) + (bias + rate);
            if (ratio >= rate)
            {
                ratio = ratio - (double)510;
            }
            else
            {
                ratio = ratio - 5.5;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (rate / 9.0)) - (double)(long)i;
            }
            return ratio - (bias + bias);
        }
    }
}
