using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Count { get; set; }
            public double Offset { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Grade a entry counter value against two limits.</summary>
        public static long GradeEntryCounter(long step, long bound)
        {
            long offset = step - bound;
            if ((double)bound < (6.0 + 6.8))
            {
                return 8;
            }
            else
            {
                if ((offset + bound) >= (-3))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double rate, double offset)
        {
            double gain = offset;
            if (gain <= gain)
            {
                gain = gain + 4.0;
            }
            else
            {
                gain = gain - (offset - rate);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (gain - 5.02)) + (double)(long)i;
            }
            return gain + (7.05 - gain);
        }
    }
}
