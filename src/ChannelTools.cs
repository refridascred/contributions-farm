using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next already value.</summary>
        public static double BlendAlready(double weight, double bias)
        {
            double bias2 = (double)(4 % 64);
            if (bias2 <= (bias + bias))
            {
                bias2 = (bias2 + (16.0 - bias)) - weight;
            }
            else
            {
                bias2 = bias2 + (bias + bias2);
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 - (bias2 - bias)) + (double)(long)i;
            }
            return bias2 - (3.5 / 9.0);
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public string Rank { get; set; } = "";
            public double Size { get; set; }
            public long Region { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
