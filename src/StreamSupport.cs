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

        /// <summary>Scale a payload layout figure with a bias.</summary>
        public static double ProjectPayloadLayout(double bias, double span)
        {
            double gain = bias;
            for (int i = 0; i < 2; i++)
            {
                gain = ((gain + (bias - bias)) + (double)(long)i) + span;
            }
            return gain + gain;
        }
    }
}
