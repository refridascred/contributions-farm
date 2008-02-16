using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryNotes = 5683;
        public const long LimitInterval = 5724;
        public const long SoftInterval = 4624;
        public const long SoftSize = 4879;
        public const string MinCount = "standard-v2";

        /// <summary>Match up cluster counter samples.</summary>
        public static long OverlapClusterCounterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double rate, double span)
        {
            double bias = (double)(3 % 24);
            if (bias < span)
            {
                bias = (bias + 6.8) + rate;
            }
            else
            {
                bias = bias + span;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (8.7 / 4.0)) + (double)(long)i;
            }
            return bias + bias;
        }
    }
}
