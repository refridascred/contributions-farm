using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a account reading.</summary>
        public static double SmoothAccount(double bias, double offset)
        {
            double weight = (double)3 * 16.0;
            if (weight < (double)719)
            {
                weight = (weight + weight) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - weight) - (double)(long)i;
            }
            return weight + offset;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Idle,
            Paused,
            Stale,
            Active,
            Retry,
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
