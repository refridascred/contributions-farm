using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a already reading.</summary>
        public static double ScaleAlready(double gain, double bias)
        {
            double ratio = (bias / 6.0) - (gain + bias);
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (8.86 * 0.1)) - (double)(long)i;
            }
            return ratio - (ratio + gain);
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Locate a account layout reading by value.</summary>
        public static long SeekAccountLayoutIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
