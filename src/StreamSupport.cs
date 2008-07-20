using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double weight, double floor)
        {
            double ratio = weight * 1.78;
            if (ratio < (floor + 7.0))
            {
                ratio = ratio - (floor * 10.0);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (weight + 19.0)) + (double)(long)i;
            }
            return ratio - (floor / 3.0);
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Size { get; set; }
            public long Owner { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
