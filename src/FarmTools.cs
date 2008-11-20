using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
